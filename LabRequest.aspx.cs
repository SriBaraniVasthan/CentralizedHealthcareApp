using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalAdministration
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        void Binddata()
        {

            try
            {
                List<ITest> listAlloc = new List<ITest>();
                IDBClass objDB = new DBClass();
                listAlloc = objDB.ViewRequestHistory(Session["Doctor"].ToString());
                gvrReqHistory.DataSource = listAlloc;
                gvrReqHistory.DataBind();


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
    }
}