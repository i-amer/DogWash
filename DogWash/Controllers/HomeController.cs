using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogWash.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Dog Wash";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Dog Wash";

            return View();
        }
        public ActionResult Schedule()
        {
            ViewBag.Message = "View Schedules Here";

            return View();
        }

    }
}