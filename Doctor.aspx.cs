using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalAdministration
{
    public partial class WebForm2 : System.Web.UI.Page
    {





        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Doctor"] != null)
                {
                    txtdoctorname.Text = Session["Doctor"].ToString();

                }


                if (!Page.IsPostBack)
                {
                    List<ITest> listProj = new List<ITest>();
                    IDBClass objDB = new DBClass();
                    listProj = objDB.TestDdl();
                    ddltestname.DataSource = listProj;
                    ddltestname.DataTextField = "TestName";
                    ddltestname.DataValueField = "TestName";
                    ddltestname.DataBind();
                    ddltestname.Items.Insert(0, "select");

                }


            }

            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:" + ex.Message + "');", true);
            }           
           
          
          

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            //Session["test"] = ddltestname.SelectedItem.Text;
            int i = 0;
            ITest objhsp = new Test();
            IDBClass objDB = new DBClass();

            try
            {
                objhsp.AdminName = txtadmin.Text;
                objhsp.DoctorName = txtdoctorname.Text;
                objhsp.TestName = ddltestname.SelectedItem.Text;
                objhsp.Status = "Sent to Admin";
                i = objDB.AddRequest(objhsp);
                if (i > 0)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Request sent to admin successfully');", true);

                    txtadmin.Text = " "; ;
               txtdoctorname.Text=" ";
               ddltestname.ClearSelection();

                }
                Session["Notify"] = "You have a request from Doctor";
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