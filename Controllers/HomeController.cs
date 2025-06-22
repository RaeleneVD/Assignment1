using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectService()
        {
            ViewBag.Message = "Select Service page.";

            return View();
        }

        public ActionResult BookingForm(string service)
        {
            ViewBag.service = service;

            return View();
        }

        public ActionResult BookingConfirmed()
        {
            return View();

        }

        public ActionResult RideHistory()
        {
            return View();

        }

        public ActionResult Manage()
        {
            return View();

        }
    }
}