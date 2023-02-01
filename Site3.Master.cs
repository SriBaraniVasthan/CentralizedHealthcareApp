using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalAdministration
{
    public partial class Site3 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
            {

                Label1.Text = Session["Admin"].ToString();
                Label2.Text = "Logged in time:" + "  " + Request.Cookies["timesession"].Value.ToString();
            }
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

            if (Session["Notify"] != null)
            {
                Session.Abandon();
                Session.Clear();

            }
            if (Session["LabNotify"] != null)
            {
                Session.Abandon();
                Session.Clear();

            }
            if (Session["RequestTime"] != null)
            {
                Session.Abandon();
                Session.Clear();

            }

            //if (Request.Cookies["timesession"] != null)
            //{
            //    Response.Cookies["timesession"].Expires = DateTime.Now.AddDays(-1);
            //}
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (Session["Notify"] != null)
            {
                Session.Abandon();
                Session.Clear();

            }
            if (Session["LabNotify"] != null)
            {
                Session.Abandon();
                Session.Clear();

            }
            if (Session["RequestTime"] != null)
            {
                Session.Abandon();
                Session.Clear();

            }
            Response.Redirect("HomePage.aspx");
        }
    }
}