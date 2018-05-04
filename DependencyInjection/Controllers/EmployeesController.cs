using DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }
        private IEmployeeService _iEmployeeService;

        public EmployeesController(IEmployeeService iEmployeeService)
        {
            _iEmployeeService = iEmployeeService;
        }

        public ActionResult GetEmployee()
        {
            return Json(_iEmployeeService.GetEmployees(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetEmployeeEntities()
        {
            return Json(_iEmployeeService.GetEmployeeEntities(), JsonRequestBehavior.AllowGet);
        }
    }
}