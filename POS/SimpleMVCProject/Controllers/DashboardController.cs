using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVCProject.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int firstNumber, int secondNumber)
        {
            ViewBag.AddResult = firstNumber + secondNumber;
            return View();
        }

        [ActionName("getsimple")]
        public ActionResult Hi()
        {
            return View("Simple");
        }

        [ActionName("getsimple2")]
        public ActionResult Hi(int firstNumber, int secondNumber)
        {
            ViewBag.AddResult = firstNumber + secondNumber;
            return View("Simple");
        }
    }
}