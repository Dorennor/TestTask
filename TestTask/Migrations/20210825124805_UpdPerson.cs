using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask.Migrations
{
    public partial class UpdPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("f89a8ff8-5142-4c82-b037-e1f9d6172cf4"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("473ecfd0-5c63-40da-a5b1-ca24086c48fe"), "Vladimir", "Rud" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("473ecfd0-5c63-40da-a5b1-ca24086c48fe"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { new Guid("f89a8ff8-5142-4c82-b037-e1f9d6172cf4"), "Vladimir", "Rud" });
        }
    }
}
