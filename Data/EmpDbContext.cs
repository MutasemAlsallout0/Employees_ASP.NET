using HwEmployees.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HwEmployees.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions options) : base(options)
        {

        }
       public DbSet<Employee> Employees { get; set; }
       public DbSet<Salary> Salaries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
                .HasData(new List<Employee>()
                {
                    new Employee()
                    {
                        Id = 1,
                        Name = "ali",
                        Salary = 1000,
                        DOB = DateTime.Now.AddYears(-20)
                    },
                       new Employee()
                    {
                        Id = 2,
                        Name = "ahmad",
                        Salary = 2000,
                        DOB = DateTime.Now.AddYears(-20)
                    },
                          new Employee()
                    {
                        Id = 3,
                        Name = "nada",
                        Salary = 3000,
                        DOB = DateTime.Now.AddYears(-20)
                    },
                             new Employee()
                    {
                        Id = 4,
                        Name = "heba",
                        Salary = 1500,
                        DOB = DateTime.Now.AddYears(-20)
                    },
                });
        }
    }
}
