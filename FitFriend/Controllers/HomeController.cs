using FitFriend.Models;
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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        FitDBContext db = new FitDBContext();
    //    public ActionResult Track()
      //  {
       //     List<object> model = new List<object>();
       //     model.Add(db.Food.ToList());
       //     model.Add(db.Exercises.ToList());
       //     return View(model);
       // }
       
        public ActionResult Recipes()
        {
            List<object> model = new List<object>();
            model.Add(db.Recipes.ToList());
            return View(model);
        }
        public ActionResult BMI()
        {
            return View();
        }

    }
}