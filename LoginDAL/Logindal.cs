using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using BALlibraries;
namespace  DALlibraries
{
    public class Logindal
    {
        public bool CheckCredentials(BALlibraries.Loginbal userdetails)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnflamingo"].ConnectionString);
            SqlCommand cmd = new SqlCommand("sp_Insert_Login_Details", cn);
             cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emailid", userdetails.UserID);
            cmd.Parameters.AddWithValue("@password", userdetails.Password);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            bool status = false;
            if (dr.HasRows)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            cn.Close();
            return status;


        }
        public bool ChangePassword(BALlibraries.Loginbal userdetails)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnflamingo"].ConnectionString);
            SqlCommand cmd = new SqlCommand("sp_update_Login_Details", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emailid", userdetails.UserID);
            cmd.Parameters.AddWithValue("@password", userdetails.Password);
            cn.Open();
            int rows = cmd.ExecuteNonQuery();
            bool status = false;
            if (rows >= 1)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            cn.Close();
            return status;
        }
    }
}