using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalAdministration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        IDBClass objDB = new DBClass();
        int flag;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Notify"] != null)
            //{
            //    Session.Abandon();
            //    Session.Clear();

            //}
            //if (Session["LabNotify"] != null)
            //{
            //    Session.Abandon();
            //    Session.Clear();

            //}
          
          
            //if (Request.Cookies["timesession"] != null)
            //{
            //    Response.Cookies["timesession"].Expires = DateTime.Now.AddDays(-1);
            //}
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (rdoDoctor.Checked == true)
                {
                    flag = objDB.CheckLogin1(txtUserID.Text, txtPassword.Text);
                    if (flag == 1)
                    {
                        Session["Doctor"] = txtUserID.Text;
                        Response.Cookies["timesession"].Value = DateTime.Now.ToString();
                        Session["RequestTime"] = DateTime.Now.ToString();
                        Response.Redirect("Doctor.aspx");
                    }
                    else
                    {

                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Invalid ID or Password');", true);
                        txtUserID.Text = "";
                        txtPassword.Text = "";


                    }
                }
                else if (rdoAdmin.Checked == true)
                {
                    flag = objDB.CheckLogin3(txtUserID.Text, txtPassword.Text);
                    if (flag == 1)
                    {
                        Session["Admin"] = txtUserID.Text;
                        Response.Cookies["timesession"].Value = DateTime.Now.ToString();
                        Response.Redirect("Admin.aspx");
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Invalid ID or Password');", true);
                        txtUserID.Text = "";
                        txtPassword.Text = "";

                    }
                }
                else if (rdoLab.Checked == true)
                {
                    flag = objDB.CheckLogin2(txtUserID.Text, txtPassword.Text);
                    if (flag == 1)
                    {
                        Session["Labname"] = txtUserID.Text;
                        Response.Cookies["timesession"].Value = DateTime.Now.ToString();
                        Response.Redirect("Lab.aspx");
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Invalid ID or Password');", true);
                        txtUserID.Text = "";
                        txtPassword.Text = "";

                    }

                }


            }

            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:" + ex.Message + "');", true);
            }           
           
          

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = rdoDoctor.Checked || rdoAdmin.Checked || rdoLab.Checked;
        }
      
    }
}