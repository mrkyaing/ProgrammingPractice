using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleMVCProject.Models;
namespace SimpleMVCProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetAll()
        {
            return View("List");
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel employeeModel)
        {
            ViewBag.Message = $"{employeeModel.EmployeeId} was created with the gender of {employeeModel.Gender}";
            return View();
        }
    }
}