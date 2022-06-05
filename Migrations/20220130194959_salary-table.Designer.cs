﻿// <auto-generated />
using System;
using HwEmployees.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HwEmployees.Migrations
{
    [DbContext(typeof(EmpDbContext))]
    [Migration("20220130194959_salary-table")]
    partial class salarytable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HwEmployees.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DOB = new DateTime(2002, 1, 30, 21, 49, 58, 429, DateTimeKind.Local).AddTicks(6583),
                            Name = "ali",
                            Salary = 1000
                        },
                        new
                        {
                            Id = 2,
                            DOB = new DateTime(2002, 1, 30, 21, 49, 58, 433, DateTimeKind.Local).AddTicks(4079),
                            Name = "ahmad",
                            Salary = 2000
                        },
                        new
                        {
                            Id = 3,
                            DOB = new DateTime(2002, 1, 30, 21, 49, 58, 433, DateTimeKind.Local).AddTicks(4146),
                            Name = "nada",
                            Salary = 3000
                        },
                        new
                        {
                            Id = 4,
                            DOB = new DateTime(2002, 1, 30, 21, 49, 58, 433, DateTimeKind.Local).AddTicks(4154),
                            Name = "heba",
                            Salary = 1500
                        });
                });

            modelBuilder.Entity("HwEmployees.Models.Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bonus")
                        .HasColumnType("int");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("NetSalary")
                        .HasColumnType("int");

                    b.Property<int>("Overtime")
                        .HasColumnType("int");

                    b.Property<int>("Penalties")
                        .HasColumnType("int");

                    b.Property<int>("PenaltiesDays")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("HwEmployees.Models.Salary", b =>
                {
                    b.HasOne("HwEmployees.Models.Employee", "Employee")
                        .WithMany("Salaries")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HwEmployees.Models.Employee", b =>
                {
                    b.Navigation("Salaries");
                });
#pragma warning restore 612, 618
        }
    }
}