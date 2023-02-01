using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalAdministration
{
    public partial class Site4 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Labname"] != null)
            {

                Label1.Text = Session["Labname"].ToString();
                Label2.Text = "Logged in time" + "  " + Request.Cookies["timesession"].Value.ToString();
            }
        }
    }
}