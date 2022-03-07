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
        private POSDbContext pOSDbContext;
        public CityController()
        {
            pOSDbContext = new POSDbContext();
        }
        public ActionResult Index()
        {
            return View();
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