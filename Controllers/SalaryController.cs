using HwEmployees.Data;
using HwEmployees.Models;
using HwEmployees.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HwEmployees.Controllers
{
    public class SalaryController : Controller
    {
        readonly EmpDbContext _context;

        public int BasicSalary { get; private set; }

        public SalaryController(EmpDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            var salaries = _context.Salaries
                .Include(x => x.Employee)
                .Where(x => x.EmpId == id)
                .Select(x => new SalaryViewModel
                {
                    EmpId = x.EmpId,
                    BasicSalary = x.Employee.Salary,
                    Name = x.Employee.Name,
                    Bonus = x.Bonus,
                    Discount = x.Discount,
                    Overtime = x.Overtime,
                    PenaltiesDays = x.PenaltiesDays,
                    Month = x.Month,
                    Year = x.Year,
                    Penalties = x.Penalties,
                    NetSalary = x.NetSalary,

                })
                .ToList();
            var employees = _context.Employees.Select(x => new { Id = x.Id, Name = x.Name }).ToList();
            ViewBag.employeesList = new SelectList(employees, "Id", "Name", id ?? employees.FirstOrDefault().Id);
            return View(salaries);
        }
        [HttpGet]
        public IActionResult Calc(int id)
        {
            var emp = _context.Employees.Find(id);
            var vm = new SalaryViewModel
            {
                Name = emp.Name,
                BasicSalary = emp.Salary,
                Month = DateTime.Now.Month,
                Year = DateTime.Now.Year,
                EmpId = emp.Id,
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult Calc(SalaryViewModel vm)
        {
            if (_context.Salaries.Any(x => x.Year == vm.Year && x.Month == vm.Month && x.EmpId == vm.EmpId))
                ModelState.AddModelError("Salary", "you can not take more than one salary in the same month");
            if (!ModelState.IsValid)
                return View(vm);
            var penalty = vm.PenaltiesDays * (vm.BasicSalary / 22);
            var netSalary = vm.BasicSalary + vm.Bonus + vm.Overtime - penalty - vm.Discount;
            var model = new Salary()
            {
                Month = vm.Month,
                Year = vm.Year,
                Bonus = vm.Bonus,
                Discount = vm.Discount,
                EmpId = vm.EmpId,
                Overtime = vm.Overtime,
                Penalties = penalty,
                PenaltiesDays = vm.PenaltiesDays,
                NetSalary = netSalary
            };
            _context.Salaries.Add(model);
            _context.SaveChanges();
            return View(vm);
        }
    }
}
