using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace CADLAB.Controllers
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

        public ActionResult Crash()
        {
            throw new Exception("Boooom!");
        }

        public ActionResult LongOperation()
        {
            Thread.Sleep(10000);

            return View();
        }

        public ActionResult CustomEvents()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomEvents(string eventName)
        {
            var telemetry = new TelemetryClient();

            telemetry.TrackEvent(eventName);

            return RedirectToAction("Index");
        }
    }
}