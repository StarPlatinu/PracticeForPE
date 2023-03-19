using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q3.Models;
using System.Collections.Generic;
using System.Linq;

namespace Q3.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly PRN_Sum22_B1Context _context = new();

        public IActionResult List(int id)
        {
            List<Department> departments = _context.Departments.ToList();
            List<Employee> employees = new();
            if (id != 0)
            {
                employees = _context.Employees.Include(x => x.Department).Where(x => x.DepartmentId == id).ToList();
            }
            else
            {
                employees = _context.Employees.ToList();
            }
            ViewData["Departments"] = departments;
            ViewData["id"] = id;    
            return View(employees);
        }
    }
}
