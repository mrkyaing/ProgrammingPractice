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

        public ActionResult List()
        {
            List<TownshipViewModel> townshipViewModels = (from t in pOSDbContext.Townships
                                                          join c in pOSDbContext.Cities
                                                           on t.CityId equals c.Id
                                                          select new TownshipViewModel
                                                          {
                                                              Id = t.Id,
                                                              Name = t.Name,
                                                              ZipCode = t.ZipCode,
                                                              CityId = t.CityId,
                                                              CityName = c.Name
                                                          }).ToList();
            return View(townshipViewModels);
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
            TownshipModel township = new TownshipModel()
            {

               Id=Guid.NewGuid().ToString(),
               ZipCode=townshipViewModel.ZipCode,
               Name=townshipViewModel.Name,
               CityId=townshipViewModel.CityId
            };
            pOSDbContext.Townships.Add(township);
            pOSDbContext.SaveChanges();
           return RedirectToAction("List");
        }
    }
}