using DotNetNote.Models.Companies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNote.BlazorServer.Controllers
{
    public class CompaniesController : Controller
    {
        //private IConfiguration _configuration;
        private ICompanyRepository _repositroy;

        //public CompaniesController(IConfiguration configuration, ICompanyRepository repositroy)
        public CompaniesController(ICompanyRepository repositroy)
        {
            //_configuration = configuration;
            _repositroy = repositroy;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            ViewBag.Message = $"{name}을 입력 했습니다.";
            return View();
        }

        [HttpGet]
        public IActionResult Manage()
        {
            var companies = _repositroy.Read();
            return View(companies);
        }

        //[HttpPost]
        //public IActionResult Manage(CompanyModel model)
        //{
        //    var r = _repositroy.Add(model);
        //    return View(r);
        //}
        [HttpPost]
        public IActionResult Manage(string name)
        {
            _repositroy.Add(new CompanyModel { Name = name });
            //return View();
            return RedirectToAction(nameof(Manage));
        }
    }
}
