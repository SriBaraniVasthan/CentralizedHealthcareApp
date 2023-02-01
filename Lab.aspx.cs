using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalAdministration
{
    public partial class WebForm4 : System.Web.UI.Page
    {

        void Binddata()
        {
        

        
            try
            {
                string labname = Session["LabName"].ToString();
                List<ITest> listAlloc = new List<ITest>();
                IDBClass objDB = new DBClass();

                listAlloc = objDB.viewLabfromAdmin(labname);
                gvrAdminReq.DataSource = listAlloc;
                gvrAdminReq.DataBind();


            }

            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:" + ex.Message + "');", true);
            }           
           
          
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                Binddata();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void gvrAdminReq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}