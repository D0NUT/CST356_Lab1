using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _CST356_PatrickMiki_Lab1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //TestComment
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The About Page";
            ViewBag.Message += ", yet another message for ViewBag.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}