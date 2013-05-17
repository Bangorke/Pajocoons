using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pajocoons.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Pajocoons Cattery";

            return View();
        }

        public ActionResult Males()
        {
            return View();
        }
        public ActionResult Females()
        {
            return View();
        }
        public ActionResult Kittens()
        {
            return View();
        }
        public ActionResult Others()
        {
            return View();
        }
        public ActionResult Media()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
