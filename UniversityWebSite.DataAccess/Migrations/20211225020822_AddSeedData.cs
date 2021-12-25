using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityWebSite.DataAccess.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CreatedTime", "Password", "UpdatedTime", "Username" },
                values: new object[] { 1, new DateTime(2021, 12, 25, 5, 8, 22, 611, DateTimeKind.Local).AddTicks(6800), "123456a", null, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
