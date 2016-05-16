using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Intro.Models;

namespace MVC_Intro.ViewModels
{
    public class EmployeeDetailViewModel
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public string DepartmentName { get; set; }
    }
}