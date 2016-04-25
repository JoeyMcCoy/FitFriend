using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitFriend.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "FitFriend is an easy-to-use application for tracking your personal fitness and diet information!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact FitFriend today!";

            return View();
        }
    }
}