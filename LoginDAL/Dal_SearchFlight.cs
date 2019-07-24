
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALlibraries;
namespace DALlibraries
{
  public  class Dal_SearchFlight
    {
        public bool CheckCredentials(Bal_SearchFlight searchResult)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnflamingo"].ConnectionString);
            SqlCommand cmd = new SqlCommand("sp_Insert_Login_Details", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@from", searchResult.From);
            cmd.Parameters.AddWithValue("@to", searchResult.To);
            cmd.Parameters.AddWithValue("@departure", searchResult.Departure);
            cmd.Parameters.AddWithValue("@arrival", searchResult.Arrival);
            cmd.Parameters.AddWithValue("@traveller", searchResult.Traveller);

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


        public DataTable SearchUserFlight(Bal_SearchFlight search, out bool availablestatus)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnflamingo"].ConnectionString);
            SqlCommand cmd = new SqlCommand("sp_SearchFlight", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@from",search.From);
            cmd.Parameters.AddWithValue("@to", search.To);
            cmd.Parameters.AddWithValue("@neededtickets", search.Traveller);
            cmd.Parameters.AddWithValue("@departuredate", search.Departure);
            SqlParameter p1 = new SqlParameter("@status", SqlDbType.Bit);
            p1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p1);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            availablestatus = false;
            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
                availablestatus = true;
                dt.Load(dr);
              
            }
            
            cn.Close();
            return dt;


        }
    }
}
