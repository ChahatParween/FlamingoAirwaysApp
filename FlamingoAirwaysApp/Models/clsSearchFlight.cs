using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlamingoAirwaysApp.Models
{
    public class clsSearchFlight
    {
        public int FlightNo { get; set; }

        private string from;
        [Required]
        public string From
        {
            get { return from; }
            set { from = value; }
        }

        private string to;
        [Required]
        public string To
        {
            get { return to; }
            set { to = value; }
        }

        private DateTime departure;
        [Required]
        public DateTime Departure
        {
            get { return departure; }
            set { departure = value; }
        }

        private DateTime arrival;
        [Required]
        public DateTime Arrival
        {
            get { return arrival; }
            set { arrival = value; }
        }

        private int traveller;
        [Required]
        public int Traveller
        {
            get { return traveller; }
            set { traveller = value; }
        }




    }
}