using FlamingoAirwaysApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlamingoAirwaysApp.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FlightBooking()
        {

            return View();
        }

        [HttpPost]
        public ActionResult FlightBooking(clsSearchFlight flightdata)
        {

            return View();
        }
    }
}