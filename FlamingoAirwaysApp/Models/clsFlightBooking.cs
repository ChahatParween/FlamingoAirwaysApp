using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlamingoAirwaysApp.Models
{
    public class clsFlightBooking:clsSearchFlight
    {
        private int ticketno;
        [Display(Name = "Ticket No.")]
        public int TicketNo     
        {
            get { return ticketno; }
            set { ticketno = value; }
        }
        private DateTime ticketdate;
        [Display(Name = "Ticket Date")]
        public DateTime TicketDate
        {
            get { return ticketdate; }
            set { ticketdate = value; }
        }

    }
}