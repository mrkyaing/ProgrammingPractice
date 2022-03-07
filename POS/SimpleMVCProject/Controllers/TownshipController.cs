using SimpleMVCProject.Models;
using SimpleMVCProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVCProject.Controllers
{
    public class TownshipController : Controller
    {
        private POSDbContext pOSDbContext;
        public TownshipController()
        {
            pOSDbContext = new POSDbContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var cityViewModel = pOSDbContext.Cities.Select(s => new CityViewModel
            {
                Id = s.Id,
                Name = s.Name
            });
            return View(cityViewModel);
        }
        [HttpPost]
        public ActionResult Create(TownshipViewModel townshipViewModel)
        {
            return View();
        }
    }
}