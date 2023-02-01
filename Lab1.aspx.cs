using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalAdministration
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {


                if (!Page.IsPostBack)
                {
                    string id = Request.QueryString["Id"];
                    string Reqid = Request.QueryString["ReqID"];

                    txtTestName.Text = id;
                    Label1.Text = Reqid;
                }

            }

            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:" + ex.Message + "');", true);
            }           
           
          

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void btnResults_Click(object sender, EventArgs e)
        {

            ILab objhsp = new Lab();
            IDBClass objDB = new DBClass();
            try
            {              
                objhsp.LabName = Session["Labname"].ToString();
                objhsp.TestResults = txtTestResults.Text;
                objhsp.AdminName = txtAdminName.Text;
                objhsp.TestName = txtTestName.Text;
                objhsp.RequestID = int.Parse(Label1.Text);
                string DoctorName = Request.QueryString["DoctorName"];
                objhsp.DoctorName = DoctorName;
                objhsp.Status = "Results sent to Admin";
                int i = objDB.AddlabResults(objhsp);
                if (i > 0)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Results sent to admin');", true);
                  txtTestResults.Text="";
                     txtAdminName.Text="";
                   txtTestName.Text="";
                Label1.Text="";
                   
                }
                Session["LabNotify"] = "Lab has sent test results";


            }

            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:" + ex.Message + "');", true);
            }           
           
          
        }
    }
}