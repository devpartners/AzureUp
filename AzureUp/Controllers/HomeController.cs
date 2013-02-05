using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureUp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to AzureUp!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About AzureUp";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacting AzureUp!";

            return View();
        }
    }
}
