using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace ExperimentsInTracing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Trace.WriteLine("Started the Index Method in the Home Controller - Trace.writeline");
            
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

        public ActionResult ForceError()
        {
            Trace.WriteLine("Started the ForceError Method in the Home Controller - Trace.writeline");
           
            //this makes it into elmah, but wouldn't use this except in the worst case. 
            throw new System.NotSupportedException("Test Exception");

            return View();
        }





    }
}