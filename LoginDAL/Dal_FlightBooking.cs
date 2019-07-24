using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BALlibraries;

namespace DALlibraries
{
    class Dal_FlightBooking
    {
        public bool CheckCredentials(Bal_FlightBooking bookingDetails)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnflamingo"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from Bookings", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ticketno", bookingDetails.TicketNo);
            cmd.Parameters.AddWithValue("@ticketdate", bookingDetails.TicketDate);

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

    }
}
