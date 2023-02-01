using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalAdministration
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        void Binddata2()
        {
            try
            {

                List<ILab> listAlloc = new List<ILab>();
                IDBClass objDB = new DBClass();
                listAlloc = objDB.Viewlabresults();
                gvrLabReq.DataSource = listAlloc;
                gvrLabReq.DataBind();

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
                Binddata2();
            }
        }
    }
}