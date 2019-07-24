using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlamingoAirwaysApp.Models;
namespace FlamingoAirwaysApp.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Payment()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Payment(clsPayment payment)
        {

            return View();
        }
    }
}