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
        private IHostingEnvironment _environment;
        private readonly IMapper _mapper;

        public AdmissionController(IHostingEnvironment environment, IAdmission adm, IMapper mapper)
        {
            _environment = environment;
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
        public IActionResult AddStudent(ApplicationViewModel frm)// IFormFile Photo,IFormFile StudentSignature,IFormFile ParentSignature)// 
        {


            if (ModelState.IsValid)
            {
                _adm.SaveImages(frm);
                var appform = _mapper.Map<ApplicationForm>(frm);
                _adm.AddStudent(appform);
                return RedirectToAction("Index");
            }
            ViewBags();
            return View("AddStudent", frm);
        }

        public IActionResult UpdateStudent(int ApplicationNo)
        {
            //ViewBag.Student=_adm.getStudent(ApplicationNo);
            return View();
        }
    }
}