using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalAdministration
{
    public partial class WebForm11 : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {


                if (!Page.IsPostBack)
                {
                    string TestName = Request.QueryString["TestName"];
                    Label1.Text = TestName;
                    string Labname = Request.QueryString["LabName"];
                    Label3.Text = Labname;
                    Calendar1.Visible = false;
                }


            }

            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:" + ex.Message + "');", true);
            }           
           
          

        }


        protected void btnRating_Click(object sender, EventArgs e)
        {
            try
            {

                int i = 0;
                IDBClass objDB = new DBClass();
                ILab objLab = new Lab();
                objLab.LabName = Label3.Text;
                objLab.Rating = int.Parse(ddlRating.SelectedItem.Text);
                objLab.Comments = txtComment.Text;
                objLab.DoctorName = Session["Doctor"].ToString();
                objLab.RatingDate = DateTime.Parse(txtRateDate.Text);
                DateTime CurrentDate = DateTime.Parse(txtRateDate.Text);
                DateTime PreviousDate = objDB.CheckRatingDate(Session["Doctor"].ToString(), Label3.Text);
                TimeSpan difference = CurrentDate - PreviousDate;
                double days = difference.TotalDays;
                if (days < 30)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Lab:" + Label3.Text + " should be rated once in a month only');", true);
                    Label1.Text = "";
                    Label3.Text = "";
                    ddlRating.ClearSelection();
                    txtComment.Text = "";
                    txtRateDate.Text = "";
                }
                else
                {
                    i = objDB.AddRating(objLab);
                }
           

                if (i > 0)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Rating added');", true);
                    Label1.Text = "";
                   Label3.Text="";
                   ddlRating.ClearSelection();
                    txtComment.Text="";
                    txtRateDate.Text = "";
                }



            }

            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:" + ex.Message + "');", true);
            }           
           
          
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
           if(Calendar1.Visible)
           {
               Calendar1.Visible = false;
           }
           else
           {
               Calendar1.Visible = true;
           }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {


                txtRateDate.Text = Calendar1.SelectedDate.ToShortDateString();
                Calendar1.Visible = false;

            }

            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:" + ex.Message + "');", true);
            }           
           
          
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            try
            {

                DateTime pastday = e.Day.Date;
                DateTime date = DateTime.Now;
                int year = date.Year;
                int month = date.Month;
                int day = date.Day;
                DateTime today = new DateTime(year, month, day);
                if (pastday.CompareTo(today) < 0)
                {
                    e.Cell.BackColor = System.Drawing.Color.Gray;
                    e.Day.IsSelectable = false;
                }


            }

            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Exception handled:" + ex.Message + "');", true);
            }           
           
          
        }
    }
}