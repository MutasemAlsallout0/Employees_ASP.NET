using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HwEmployees.Migrations
{
    public partial class emptable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DOB", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, new DateTime(2002, 1, 29, 15, 27, 6, 880, DateTimeKind.Local).AddTicks(6461), "ali", 1000 },
                    { 2, new DateTime(2002, 1, 29, 15, 27, 6, 886, DateTimeKind.Local).AddTicks(3566), "ahmad", 2000 },
                    { 3, new DateTime(2002, 1, 29, 15, 27, 6, 886, DateTimeKind.Local).AddTicks(3661), "nada", 3000 },
                    { 4, new DateTime(2002, 1, 29, 15, 27, 6, 886, DateTimeKind.Local).AddTicks(3676), "heba", 1500 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
