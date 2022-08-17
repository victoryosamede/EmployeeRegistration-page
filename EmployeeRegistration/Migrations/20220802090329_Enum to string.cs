using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeRegistration.Migrations
{
    public partial class Enumtostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Victory's Employees",
                keyColumn: "Id",
                keyValue: new Guid("9fad6712-fb9d-47c7-9dd8-d51fc3927980"));

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Victory's Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Victory's Employees",
                columns: new[] { "Id", "Age", "The first name", "Gender", "LastName" },
                values: new object[] { new Guid("a4b61f46-a699-4734-a4cd-85b42559d082"), 30, "Bart", "Male", "Allen" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Victory's Employees",
                keyColumn: "Id",
                keyValue: new Guid("a4b61f46-a699-4734-a4cd-85b42559d082"));

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Victory's Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Victory's Employees",
                columns: new[] { "Id", "Age", "The first name", "Gender", "LastName" },
                values: new object[] { new Guid("9fad6712-fb9d-47c7-9dd8-d51fc3927980"), 30, "Bart", 0, "Allen" });
        }
    }
}
