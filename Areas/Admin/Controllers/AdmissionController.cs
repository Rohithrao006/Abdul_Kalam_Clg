using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using WebApplication.Areas.Admin.Services;
using Microsoft.AspNetCore.Hosting;
using AutoMapper;

namespace WebApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdmissionController : Controller
    {
        private IAdmission _adm;
        private readonly IMapper _mapper;

        public AdmissionController(IAdmission adm, IMapper mapper)
        {
            _adm = adm;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            ViewBags();
            return View();
        }

        [NonAction]
        public void ViewBags()
        {
            ViewBag.SchoolEducation = SelectItems.SchoolEducation();
            ViewBag.Courses = SelectItems.Courses();
            ViewBag.Languages = SelectItems.Languages();
            ViewBag.castes = SelectItems.Castes();
            ViewBag.AppNo = _adm.AppNo();
        }

        [HttpPost]
        public IActionResult AddStudent(ApplicationViewModel frm)
        {
            if (ModelState.IsValid)
            {
                var appform = _mapper.Map<ApplicationForm>(frm);
                _adm.AddStudent(appform);
                _adm.SaveImages(frm);
                return RedirectToAction("Index");
            }
            ViewBags();
            return View("AddStudent", frm);
        }

        [HttpGet]
        public IActionResult EditStudent()
        {
            return View();
        }

        [HttpGet]
        public JsonResult UpdateStudent(int ApplicationNo)
        {
            ViewBags();
            var appform = _adm.getStudent(ApplicationNo);
            var AppViewForm = _mapper.Map<ApplicationViewModel>(appform);
            return Json(AppViewForm);
        }

        [HttpPost]
        public IActionResult UpdateStudent(ApplicationViewModel frm)
        {
            if (ModelState.IsValid)
            {
                var appform = _mapper.Map<ApplicationForm>(frm);
                _adm.UpdateStudent(appform);
                _adm.SaveImages(frm.ApplicationNo, frm);
                return RedirectToAction("EditStudent");
            }
            return Json("Update failed");
        }

        public PartialViewResult _EditStudent(ApplicationViewModel appform)
        {
            ViewBags();
            return PartialView(appform);
        }
    }
}