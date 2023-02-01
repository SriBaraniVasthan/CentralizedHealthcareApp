using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalAdministration
{
    public partial class WebForm3 : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            if (!Page.IsPostBack)
            {
                lblNotify.Visible = false;
                lblLabNotify.Visible = false;
                lblTime.Visible = false;
                if (Session["Notify"] != null)
                {
                    lblNotify.Visible = true;
                    lblNotify.Text = "Requests:" + Session["Notify"].ToString();

                }
                else
                {
                    lblNotify.Visible = true;
                    lblNotify.Text = " No request from Doctors";

                }

                if (Session["RequestTime"] != null)
                {
                    lblTime.Visible = true;
                    lblTime.Text = "Last Request received time:" + " " + Session["RequestTime"].ToString();

                }
               

                //if (Request.Cookies["timesession"] != null)
                //{
                //    lblTime.Visible = true;
                //    lblTime.Text = "Request received time:" + " " + Request.Cookies["timesession"].Value.ToString();
                //}
                //else
                //{
                //    lblTime.Visible = false;
                //}
               
               

                
               
               
                if (Session["LabNotify"]!=null)
                {
                    lblLabNotify.Visible = true;
                    lblLabNotify.Text = "Results:" + Session["LabNotify"].ToString();
                }
                else
                {
                    lblLabNotify.Visible = true;
                    lblLabNotify.Text = " No Results from lab";

                }
               

            }
             }

            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:" + ex.Message + "');", true);
            }           
           
        }

       

      

       
       


    }
}