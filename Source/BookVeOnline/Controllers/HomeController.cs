using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookVeOnline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Hotel()
        {
            return View();
        }
        public ActionResult Single()
        {
            return View();
        }
        public ActionResult Places()
        {
            return View();
        }
        public ActionResult Tour()
        {
            return View();
        }
        public ActionResult Tour_Details()
        {
            return View();
        }
        public ActionResult Booking()
        {
            return View();
        }
        public ActionResult Place2()
        {
            return View();
        }
        public ActionResult ConfirmBooking()
        {
            return View();
        }
        public ActionResult OtherOptions()
        {
            return View();
        }
        public ActionResult Payment()
        {
            return View();
        }
        public ActionResult ConfirmPayment()
        {
            return View();
        }
        public ActionResult Author ()
        {
            return View();
        }
        public ActionResult Complete()
        {
            return View();
        }
        public ActionResult QuanTri()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}