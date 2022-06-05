using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HwEmployees.ViewModel
{
    public class SalaryViewModel
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int BasicSalary { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        [Required]
        public int Bonus { get; set; }
        [Required]
        public int Discount { get; set; }
        [Required]
        public int Overtime { get; set; }
        [Required]
        public int PenaltiesDays { get; set; }
        public int? Penalties { get; set; }
        public int? NetSalary { get; set; }
        
    }
}
