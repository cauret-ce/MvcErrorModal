using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxErrorModal.Controllers;
using AutoMapper;
using Core.Domain;
using MvcAjaxErrorModal.ViewModels.Employee;
using Service.Employee;

namespace MvcAjaxErrorModal.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult List()
        {
            var viewModel = Mapper.Map<List<EmployeeDto>, List<EmployeeViewModel>>(_employeeService.GetEmployees());

            return PartialView("~/Views/Shared/Partials/Employees/_List.cshtml", viewModel);
        }

        [HttpGet]
        public ActionResult ShowModalEmployeeList()
        {
           return PartialView("~/Views/Shared/Partials/Employees/_ModalShowEmployees.cshtml");
        }
	}
}