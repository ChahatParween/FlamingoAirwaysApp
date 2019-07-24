using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlamingoAirwaysApp.Models;
using DALlibraries;
using BALlibraries;


namespace FlamingoAirwaysApp.Controllers
{
    public class SiteLoginController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.userid = Session["UserID"].ToString();
            return View();
        }
        [AllowAnonymous]
        public ActionResult LoginUser()
        {

            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(clsLogin user)
        {
            bool status = false;
            Loginbal userdetails = new Loginbal();
            userdetails.UserID = user.UserID;
            userdetails.Password = user.Password;
            Logindal login = new Logindal();
            status = login.CheckCredentials(userdetails);
            if (status)
            {
                Session["UserID"] = userdetails.UserID;
                return RedirectToAction("Index");
            }



            return View();
        }

        public ActionResult ChangePassword()
        {

            return View();
        }
        [HttpPost]
        public ActionResult ChangePassword(Loginbal user)
        {
            Loginbal userdetails = new Loginbal();
            userdetails.UserID = user.UserID;
            userdetails.Password = user.Password;
            Logindal dal = new Logindal();
            bool status = dal.ChangePassword(userdetails);
            if (status)
            {
                string msg = "Password changed successfully!!!";
                TempData["message"] = msg;
                return RedirectToAction("Contact", "Home");
            }
            return View();
        }
    }
}