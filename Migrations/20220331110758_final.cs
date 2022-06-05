using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HwEmployees.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2002, 3, 31, 14, 7, 58, 247, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DOB",
                value: new DateTime(2002, 3, 31, 14, 7, 58, 249, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DOB",
                value: new DateTime(2002, 3, 31, 14, 7, 58, 249, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DOB",
                value: new DateTime(2002, 3, 31, 14, 7, 58, 249, DateTimeKind.Local).AddTicks(679));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
