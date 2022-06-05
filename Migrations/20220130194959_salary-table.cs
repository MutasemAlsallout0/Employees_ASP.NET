using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HwEmployees.Migrations
{
    public partial class salarytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: false),
                    Overtime = table.Column<int>(type: "int", nullable: false),
                    Penalties = table.Column<int>(type: "int", nullable: false),
                    PenaltiesDays = table.Column<int>(type: "int", nullable: false),
                    NetSalary = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salaries_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2002, 1, 30, 21, 49, 58, 429, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2002, 1, 30, 21, 49, 58, 433, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DOB",
                value: new DateTime(2002, 1, 30, 21, 49, 58, 433, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DOB",
                value: new DateTime(2002, 1, 30, 21, 49, 58, 433, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_EmployeeId",
                table: "Salaries",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salaries");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2002, 1, 29, 15, 27, 6, 880, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2002, 1, 29, 15, 27, 6, 886, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DOB",
                value: new DateTime(2002, 1, 29, 15, 27, 6, 886, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DOB",
                value: new DateTime(2002, 1, 29, 15, 27, 6, 886, DateTimeKind.Local).AddTicks(3676));
        }
    }
}
