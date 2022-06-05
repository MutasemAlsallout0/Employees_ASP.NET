using HwEmployees.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HwEmployees.Controllers
{
    public class EmployeesController : Controller
    {
        readonly EmpDbContext _context;
        public EmployeesController(EmpDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Employees.ToList());
        }
    }
}
