using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxErrorModal.ViewModels.Employee;
using AutoMapper;
using Core.Domain;
using Service;
using Service.Employee;

namespace AjaxErrorModal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public HomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetEmployees()
        {
            var viewModel = Mapper.Map<List<EmployeeDto>, List<EmployeeViewModel>>(_employeeService.GetEmployees());

            return View(viewModel);
        }
    }
}