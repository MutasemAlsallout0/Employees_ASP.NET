using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HwEmployees.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public int Salary  { get; set; }
        public DateTime DOB  { get; set; }
        public List<Salary> Salaries  { get; set; }
    }
}
