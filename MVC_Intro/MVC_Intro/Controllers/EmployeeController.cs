using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Intro.Models;
using MVC_Intro.ViewModels;

namespace MVC_Intro.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            DataContext _myEmployeeContext = new DataContext();

            List<Employee> employee = _myEmployeeContext.Employee.OrderBy(e => e.Name).ToList();

            var employeeDepartment = (from emp in _myEmployeeContext.Employee
                                   join dept in _myEmployeeContext.Department
                                   on emp.DepartmentId equals dept.DepartmentId
                                   orderby dept.DepartmentName
                                   select new EmployeeDetailViewModel
                                   {
                                       Name = emp.Name,
                                       DepartmentName = dept.DepartmentName
                                   }).ToList();

            EmployeeDepartmentDetailViewModel employeeDetails = new EmployeeDepartmentDetailViewModel
            {
                Employees = employeeDepartment
            };

            return View(employeeDetails);
        }
    }
}