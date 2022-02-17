using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVCProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Call Index Page(Under the Home Folder)
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            //ViewBag Object is used to carry data from Controller to View (vs)
            ViewBag.GreetingMsg = hour < 12 ? $"Good Morning,Time is{DateTime.Now.ToShortTimeString()}" : $"Good Afternoon,Time is {DateTime.Now.ToShortTimeString()}";
            return View();
        }
    }
}