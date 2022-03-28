using SimpleMVCProject.Models;
using SimpleMVCProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
namespace SimpleMVCProject.Controllers
{
    public class CityController : Controller
    {
        private readonly POSDbContext pOSDbContext;

        public CityController()
        {
            pOSDbContext = new POSDbContext();
        }
        public ActionResult List()
        {
            List<CityViewModel> cityViewModel = pOSDbContext.Cities.Select(x => new CityViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return View(cityViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(CityViewModel cityViewModel)
        {
            CityModel cityModel = new CityModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = cityViewModel.Name
            };
            pOSDbContext.Cities.Add(cityModel);
            int result = await pOSDbContext.SaveChangesAsync();
            if (result > 1)
            {

            }
            return View();
        }
    }
}