using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsightAvionics.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return View();
            return Redirect("/ProductUpdateVMs"); // redirects to internal url
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            //return View();
            return Redirect("/ProductUpdateVMs"); // redirects to internal url
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            //return View();
            return Redirect("/ProductUpdateVMs"); // redirects to internal url
        }
    }
}