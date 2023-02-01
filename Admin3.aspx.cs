using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalAdministration
{
    public partial class WebForm6 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
            try
            {
                string Name = Request.QueryString["Name"];
                string Results = Request.QueryString["Results"];

                if (!Page.IsPostBack)
                {
                    txtTestName.Text = Name;
                    txtTestResults.Text = Results;
                    List<ILab> listProj = new List<ILab>();
                    IDBClass objDB = new DBClass();
                    listProj = objDB.LabDdl();


                }

            }

            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:" + ex.Message + "');", true);
            }           
        

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int i = 0;
            ILab objhsp = new Lab();
            IDBClass objDB = new DBClass();
            try
            {

                objhsp.DoctorName = txtDoctor.Text;
                objhsp.TestName = txtTestName.Text;
                objhsp.TestResults = txtTestResults.Text;
                objhsp.LabName = Request.QueryString["LabName"];
                string Docname = Request.QueryString["DocName"];
                if (Docname == txtDoctor.Text)
                {
                    i = objDB.AddResultsDoctor(objhsp);
                }
                else
                {
                   
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert(' Doctor Name for this test is invalid ');", true);
                }

                if (i > 0)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Results successfully sent to Doctor:" + objhsp.DoctorName + "');", true);

                   txtDoctor.Text="";
                    txtTestName.Text="";
                    txtTestResults.Text="";
                   
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