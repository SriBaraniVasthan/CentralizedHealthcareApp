using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalAdministration
{
    public partial class WebForm5 : System.Web.UI.Page
    {
      
             protected void Page_Load(object sender, EventArgs e)
            {
               

            
            try
            {
                string id = Request.QueryString["Id"];
                int reqID = int.Parse(Request.QueryString["ReqID"]);
                if (!Page.IsPostBack)
                {
                    txttestname.Text = id;
                    lblReqID.Text = reqID.ToString();
                    List<ILab> listProj = new List<ILab>();
                    IDBClass objDB = new DBClass();
                    listProj = objDB.LabDdl();
                    ddllabname.DataSource = listProj;
                    ddllabname.DataTextField = "LabName";
                    ddllabname.DataValueField = "LabName";
                    ddllabname.DataBind();
                    ddllabname.Items.Insert(0, "select");
                  
                }
               

            }
            
            catch( Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:" + ex.Message + "');", true);
               
            }
        }

        protected void btn_send_Click(object sender, EventArgs e)
        {
            int i = 0;
            ILab objhsp = new Lab();
            IDBClass objDB = new DBClass();
            try 
             {

                 objhsp.TestName = txttestname.Text;
                 objhsp.LabName = ddllabname.SelectedItem.Text;
                 string DocName = Request.QueryString["DocName"];
                 objhsp.RequestID = int.Parse(lblReqID.Text);
                 objhsp.DoctorName = DocName;
                 i = objDB.SendToLab(objhsp);
                 if (i > 0)
                 {
                     ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Request successfully sent to lab:" + objhsp.LabName + "');", true);
                      txttestname.Text="";
                      ddllabname.ClearSelection();
                     lblReqID.Text="";
                 }
            
            }
            catch (Exception ex) 
            { 
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:" + ex.Message + "');", true);
            }

            
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

       
        
    }
}