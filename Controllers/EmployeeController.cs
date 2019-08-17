using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TagHelpersDemo.Models;

namespace TagHelpersDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            EmployeeList list = new EmployeeList();
            list.employees = new List<Employee>();
            list.employees.Add(new Employee { Id = 101, Name = "Mahesh"});
            list.employees.Add(new Employee { Id = 102, Name = "Ramesh" });
            return View(list);
        }

        public IActionResult Details(int id, string foo)
        {
            Employee emp = new Employee();
            emp.Id = 101;
            emp.Name = "Mahesh";
            return View(emp);
        }
    }
}