
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlamingoAirwaysApp.Models;
using DALlibraries;
using BALlibraries;
using System.Data;

namespace FlamingoAirwaysApp.Controllers
{
    public class SearchFlightController : Controller
    {
        // GET: SearchFlight
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult Search()
        {

            return View();
        }
      
      [HttpPost]
        public ActionResult Search(clsSearchFlight searchflight)
        {
            Bal_SearchFlight flightdetails = new Bal_SearchFlight();
            flightdetails.From = searchflight.From;
            flightdetails.To = searchflight.To;
            flightdetails.Departure = searchflight.Departure;
            flightdetails.Traveller = searchflight.Traveller;
            Dal_SearchFlight search = new DALlibraries.Dal_SearchFlight();
            bool status = false;
            DataTable showFlights=search.SearchUserFlight(flightdetails, out status);
            TempData["Data"] = showFlights;
            TempData["noOfTickets"] = flightdetails.Traveller;

            if (status)
            {
                return RedirectToAction("ShowFlightsOnSearch");
            }

            return View();
        }


        public ActionResult ShowFlightsOnSearch()
        {
            
            List<clsSearchFlight> list = new List<clsSearchFlight>();
            DataTable dt=(DataTable)TempData["Data"];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                clsSearchFlight flightdata = new clsSearchFlight();

                flightdata.From = dt.Rows[i][1].ToString();
                flightdata.To = dt.Rows[i][2].ToString();
                flightdata.Departure =Convert.ToDateTime(dt.Rows[i][3]);
                flightdata.Traveller = Convert.ToInt32(TempData["noOfTickets"]);
              //  flightdata.Traveller = searchflight.Traveller;
                list.Add(flightdata);
            }
            
            return View(list);
        }
    }
}