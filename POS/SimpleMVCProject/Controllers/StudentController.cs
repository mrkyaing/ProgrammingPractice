using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleMVCProject.Models;
using SimpleMVCProject.ViewModels;
namespace SimpleMVCProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly POSDbContext pOSDbContext;

        public StudentController()
        {
            pOSDbContext = new POSDbContext();
        }
        // GET: Student
        public ActionResult List()
        {
            var studentViewModels = pOSDbContext.Students.Select(s =>
             new StudentViewModel
             {
                 Id = s.Id,
                 No = s.No,
                 Name = s.Name,
                 Email = s.Email,
                 Address = s.Address,
                 DOB = s.DOB,
                 FatherName = s.FatherName
             }).ToList();
            return View(studentViewModels);
        }

        public ActionResult Entry()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Entry(StudentViewModel studentViewModel)
        {
            var studentModel = new StudentModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = studentViewModel.Name,
                No = studentViewModel.No,
                Email = studentViewModel.Email,
                DOB = studentViewModel.DOB,
                Address = studentViewModel.Address,
                FatherName = studentViewModel.FatherName
            };
            pOSDbContext.Students.Add(studentModel);//save to memory 
            int result = pOSDbContext.SaveChanges();//persist to database
            string message = "";
            if (result > 0)
                message = "save success";
            else
                message = "error when save";
            ViewBag.result = message;
            return RedirectToAction("List");
        }


        public ActionResult Delete(string studentId)
        {
            StudentModel studentModel = pOSDbContext.Students.Where(x => x.Id == studentId).FirstOrDefault();
            if (studentModel != null)
            {
                pOSDbContext.Students.Remove(studentModel);
                pOSDbContext.SaveChanges();
            }
            return RedirectToAction("List");
        }

        public ActionResult Edit(string studentId)
        {
            var studentViewModel = pOSDbContext.Students.Where(x => x.Id == studentId)
                .Select(s => new StudentViewModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    Email = s.Email,
                    Address = s.Address,
                    FatherName = s.FatherName,
                    DOB = s.DOB,
                    No = s.No
                }).FirstOrDefault();
            return View(studentViewModel);
        }
        [HttpPost]
        public ActionResult Edit(StudentViewModel studentVM)
        {
            try
            {
                var studentModel = new StudentModel()
                {
                    Id = studentVM.Id,
                    Name = studentVM.Name,
                    Email = studentVM.Email,
                    DOB = studentVM.DOB,
                    No = studentVM.No,
                    Address = studentVM.Address,
                    FatherName = studentVM.FatherName,
                    UpdatedDate = DateTime.Now
                };
                //by importing this library >> System.Data.Entity.Migrations;
                pOSDbContext.Students.AddOrUpdate(studentModel);
                int result = pOSDbContext.SaveChanges();
                if (result > 0)
                {
                    return RedirectToAction("List");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return View(studentVM);
        }
    }
}