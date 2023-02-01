using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace HospitalAdministration
{
    public class DBClass : HospitalAdministration.IDBClass  
    {

        SqlConnection cn;
        SqlCommand cmd;
        static SqlDataAdapter da;
        private SqlConnection GetConnection()
        {
            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            try
            {
                if (!string.IsNullOrEmpty(conStr))
                {
                    return new SqlConnection(conStr);
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }


        public int CheckLogin1(string LoginName, string LoginPass)
        {
            try
            {

                cn = GetConnection();
                cn.Open();
                cmd = new SqlCommand("sp_CheckLogin1", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@DoctorName", LoginName));
                cmd.Parameters.Add(new SqlParameter("@DoctorPwd", LoginPass));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }


            }

            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

        }

        public int CheckLogin2(string LoginName, string LoginPass)
        {
            try
            {

                cn = GetConnection();
                cn.Open();
                cmd = new SqlCommand("sp_CheckLogin2", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@LabName", LoginName));
                cmd.Parameters.Add(new SqlParameter("@LabPwd", LoginPass));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }


            }

            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

        }


        public int CheckLogin3(string LoginName, string LoginPass)
        {
            try
            {

                cn = GetConnection();
                cn.Open();
                cmd = new SqlCommand("sp_CheckLogin3", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@AdminName", LoginName));
                cmd.Parameters.Add(new SqlParameter("@AdminPwd", LoginPass));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return 1;
                }
                else
                {
                    return -1;
                }


            }

            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

        }
        public List<ITest> TestDdl()
        {

            try
            {


                List<ITest> lst = new List<ITest>();
                cn = GetConnection();
                cn.Open();
                cmd = new SqlCommand("sp_TestDdl", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ITest objProj = new Test();

                    objProj.TestName = dr["Test_Name"].ToString();

                    lst.Add(objProj);
                }

                return lst;


            }
            catch (Exception ex)
            {
                return null;

            }

            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();


            }
        }

        public int AddRequest(ITest obj)
        {
            try
            {
                cn = GetConnection();
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_requesttoadmin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@adminname", obj.AdminName));
                cmd.Parameters.Add(new SqlParameter("@testname", obj.TestName));
                cmd.Parameters.Add(new SqlParameter("@doctorname", obj.DoctorName));
                cmd.Parameters.Add(new SqlParameter("@status", obj.Status));
                SqlParameter ReqID = new SqlParameter();
                ReqID.ParameterName = "@requestid";
                ReqID.SqlDbType = System.Data.SqlDbType.Int;
                ReqID.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(ReqID);
                int i;
                i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception ex)
            {

                return 0;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }
        }


        public int AddlabResults(ILab obj)
        {
            try
            {
                cn = GetConnection();
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_Resulttoadmin", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@adminname", obj.AdminName));
                cmd.Parameters.Add(new SqlParameter("@testname", obj.TestName));
                cmd.Parameters.Add(new SqlParameter("@testResults", obj.TestResults));
                cmd.Parameters.Add(new SqlParameter("@requestid", obj.RequestID));
                cmd.Parameters.Add(new SqlParameter("@labname", obj.LabName));
                cmd.Parameters.Add(new SqlParameter("@doctorname", obj.DoctorName));
              
                int i;
                i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception ex)
            {

                return 0;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }



        }





        public int AddResultsDoctor(ILab obj)
        {
            try
            {
                cn = GetConnection();
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_DoctorResult", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@doctorname", obj.DoctorName));
                cmd.Parameters.Add(new SqlParameter("@testname", obj.TestName));
                cmd.Parameters.Add(new SqlParameter("@testResults", obj.TestResults));
                cmd.Parameters.Add(new SqlParameter("@labname", obj.LabName));
                int i;
                i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception ex)
            {

                return 0;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }



        }

        public List<ILab> LabDdl()
        {

            try
            {


                List<ILab> lst = new List<ILab>();
                cn = GetConnection();
                cn.Open();
                cmd = new SqlCommand("sp_LabDdl", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ILab objProj = new Lab();

                    objProj.LabName = dr["LabName"].ToString();

                    lst.Add(objProj);
                }

                return lst;


            }
            catch (Exception ex)
            {
                return null;

            }

            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();


            }
        }


        public int SendToLab(ILab objl)
        {

            cn = GetConnection();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_requestlab", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@testname", objl.TestName));
            cmd.Parameters.Add(new SqlParameter("@labname", objl.LabName));
            cmd.Parameters.Add(new SqlParameter("@requestid", objl.RequestID));
            cmd.Parameters.Add(new SqlParameter("@doctorname", objl.DoctorName));
            int i;
            i = cmd.ExecuteNonQuery();
            return i;

        }


        public List<ITest> AdminProcessToLab()
        {
            ITest objEmp;
            List<ITest> lst = new List<ITest>();
            SqlDataAdapter da;

            try
            {
                cn = GetConnection();
                cmd = new SqlCommand();
                cmd.CommandText = "sp_GridData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
   
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet empDS = new DataSet();
                da.Fill(empDS);

                foreach (DataRow dr in empDS.Tables[0].Rows)
                {
                    objEmp = new Test();
                    objEmp.TestName = (dr["Test_Name"].ToString());
                    objEmp.DoctorName = (dr["Doctor_Name"].ToString());
                    objEmp.RequestID = int.Parse(dr["RequestID"].ToString());
                    objEmp.Status = (dr["Status"].ToString());


                    lst.Add(objEmp);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }

            return lst;

        }

        public List<ITest> ViewRequestHistory(string DocName)
        {
            ITest objEmp;
            List<ITest> lst = new List<ITest>();
            SqlDataAdapter da;

            try
            {
                cn = GetConnection();
                cmd = new SqlCommand();
                cmd.CommandText = "sp_RequestHistory";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.Add(new SqlParameter("@doctorname", DocName));
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet empDS = new DataSet();
                da.Fill(empDS);

                foreach (DataRow dr in empDS.Tables[0].Rows)
                {
                    objEmp = new Test();
                    objEmp.TestName = (dr["Test_Name"].ToString());
                    objEmp.RequestID = int.Parse(dr["RequestID"].ToString());
                    objEmp.Status = (dr["Status"].ToString());

                    lst.Add(objEmp);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }

            return lst;

        }

        public List<ITest> viewLabfromAdmin(string labname)
        {
            ITest objEmp;
            List<ITest> lst = new List<ITest>();
            SqlDataAdapter da;

            try
            {
                cn = GetConnection();
                cmd = new SqlCommand();
                cmd.CommandText = "sp_Grid4Data";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.Add(new SqlParameter("@labname", labname));
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet empDS = new DataSet();
                da.Fill(empDS);

                foreach (DataRow dr in empDS.Tables[0].Rows)
                {
                    objEmp = new Test();
                    objEmp.TestName = (dr["Test_Name"].ToString());
                   
                    objEmp.RequestID = int.Parse(dr["RequestID"].ToString());
                    objEmp.DoctorName = (dr["DoctorName"].ToString());

                    lst.Add(objEmp);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }

            return lst;

        }


        public List<ILab> Viewlabresults()
        {
            ILab objEmp;
            List<ILab> lst = new List<ILab>();
            SqlDataAdapter da;

            try
            {
                cn = GetConnection();
                cmd = new SqlCommand();
                cmd.CommandText = "sp_Grid2Data";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
               
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet empDS = new DataSet();
                da.Fill(empDS);

                foreach (DataRow dr in empDS.Tables[0].Rows)
                {
                    objEmp = new Lab();
                    objEmp.TestName = (dr["TestName"].ToString());
                    objEmp.TestResults = (dr["TestResults"].ToString());
                    objEmp.RequestID = int.Parse(dr["RequestID"].ToString());
                    objEmp.LabName = dr["LabName"].ToString();
                    objEmp.DoctorName = dr["DoctorName"].ToString();
                    lst.Add(objEmp);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }

            return lst;

        }


        public List<ILab> viewDoctorGrid(string DocName)
        {
            ILab objEmp;
            List<ILab> lst = new List<ILab>();
            SqlDataAdapter da;

            try
            {
                cn = GetConnection();
                cmd = new SqlCommand();
                cmd.CommandText = "sp_Grid3Data";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.Add(new SqlParameter("@doctorname", DocName));
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet empDS = new DataSet();
                da.Fill(empDS);

                foreach (DataRow dr in empDS.Tables[0].Rows)
                {
                    objEmp = new Lab();
                    objEmp.TestName = (dr["TestName"].ToString());
                    objEmp.TestResults = (dr["TestResults"].ToString());
                    objEmp.LabName = (dr["LabName"].ToString());
                    lst.Add(objEmp);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }

            return lst;

        }



        public List<ILab> ViewRatingList(string DocName)
        {
            ILab objEmp;
            List<ILab> lst = new List<ILab>();
            SqlDataAdapter da;

            try
            {
                cn = GetConnection();
                cmd = new SqlCommand();
                cmd.CommandText = "sp_ratinglist";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.Add(new SqlParameter("@doctorname", DocName));
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet empDS = new DataSet();
                da.Fill(empDS);

                foreach (DataRow dr in empDS.Tables[0].Rows)
                {
                    objEmp = new Lab();
                    objEmp.LabName = (dr["LabName"].ToString());
                    objEmp.Rating = int.Parse(dr["Rating"].ToString());
                    objEmp.Comments = (dr["Comments"].ToString());
                    lst.Add(objEmp);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }

            return lst;

        }

        public int AddRating(ILab obj)
        {
            try
            {
                cn = GetConnection();
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_rating", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@rating", obj.Rating));
                cmd.Parameters.Add(new SqlParameter("@comments", obj.Comments));
                cmd.Parameters.Add(new SqlParameter("@labname", obj.LabName));
                cmd.Parameters.Add(new SqlParameter("@doctorname", obj.DoctorName));
                cmd.Parameters.Add(new SqlParameter("@ratingdate", obj.RatingDate));
              
                int i;
                i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception ex)
            {

                return 0;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }



        }

        public DateTime CheckRatingDate(string DocName, string LabName)
        {

            DateTime NullDate = DateTime.MinValue;
            DateTime temp = NullDate;
          
          
            
            SqlDataAdapter da;

            try
            {
                cn = GetConnection();
                cmd = new SqlCommand();
                cmd.CommandText = "sp_CheckRatingDate";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.Parameters.Add(new SqlParameter("@doctorname", DocName));
                cmd.Parameters.Add(new SqlParameter("@labname", LabName));
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet empDS = new DataSet();
                da.Fill(empDS);

                foreach (DataRow dr in empDS.Tables[0].Rows)
                {
               
                     temp =DateTime.Parse(dr["RatingDate"].ToString());
                  
                
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }

            return temp;
            

        }

    }
}