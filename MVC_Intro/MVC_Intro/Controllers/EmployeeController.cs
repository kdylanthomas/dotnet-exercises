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
        // INDEX
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
                                          DepartmentName = dept.DepartmentName,
                                          EmployeeId = emp.EmployeeId
                                      }).ToList();

            EmployeeDepartmentDetailViewModel employeeDetails = new EmployeeDepartmentDetailViewModel
            {
                Employees = employeeDepartment
            };

            return View(employeeDetails);
        }

        // EDIT - GET
        [HttpGet]
        public ActionResult Edit(int employeeId)
        {
            using (DataContext _context = new DataContext())
            {
                var employeeDetails = (from emp in _context.Employee
                                       where emp.EmployeeId == employeeId
                                       select new EmployeeDetailViewModel
                                       {
                                           Name = emp.Name,
                                           EmployeeId = emp.EmployeeId
                                       }).ToList();

                EmployeeDepartmentDetailViewModel employeeModel = new EmployeeDepartmentDetailViewModel
                {
                    Name = employeeDetails.Select(a => a.Name).FirstOrDefault(),
                };

                return View(employeeModel);
            }
        }

        // EDIT - POST
        [HttpPost]
        public ActionResult Edit(EmployeeDepartmentDetailViewModel employeeDetails)
        {
            using (DataContext _context = new DataContext())
            {
                var employee = _context.Employee.Find(employeeDetails.EmployeeId);
                var department = _context.Department;
                if (ModelState.IsValid)
                {
                    employee.Name = employeeDetails.Name;
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(employeeDetails);
            }
        }

        // CREATE - GET
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // CREATE - POST
        [HttpPost]
        public ActionResult Create(EmployeeDetailViewModel employeeDetails)
        {
            using (DataContext _context = new DataContext())
            {
                if (ModelState.IsValid)
                {
                    Employee employee = new Employee
                    {
                        Name = employeeDetails.Name,
                        DepartmentId = employeeDetails.DepartmentId
                    };
                    _context.Employee.Add(employee);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(employeeDetails);
            }
        }

        // DELETE
        public ActionResult Delete(int employeeId)
        {
            if (employeeId != 0)
            {
                using (DataContext _context = new DataContext())
                {
                    Employee employee = _context.Employee.Find(employeeId);

                    _context.Employee.Remove(employee);
                    _context.SaveChanges();

                }
            }
            else
            {
                ViewBag.Title = "There was a problem";
            }
            return RedirectToAction("Index");
        }
    }
}