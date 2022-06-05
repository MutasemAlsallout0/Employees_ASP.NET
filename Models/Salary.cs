using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HwEmployees.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Discount { get; set; }
        public int Bonus { get; set; }
        public int Overtime { get; set; }
        public int Penalties { get; set; }
        public int PenaltiesDays { get; set; }
        public int NetSalary { get; set; }
        public Employee Employee { get; set; }
    }
}
