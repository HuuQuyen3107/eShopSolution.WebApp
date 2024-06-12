using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("ffd69b07-8224-4977-9894-c01049322f2f"), "b6bf27f9-f8a5-4a44-865b-d3e2f4a63eb6", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("e2903f00-4c67-4547-8c53-a29cc0715437"), new Guid("ffd69b07-8224-4977-9894-c01049322f2f") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e2903f00-4c67-4547-8c53-a29cc0715437"), 0, "5a135f55-5ade-455a-b94e-73563be965a9", new DateTime(2000, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "qtran0835@gmail.com", true, "Huu", "Quyen", false, null, "qtran0835@gmail.com", "admin", "AQAAAAEAACcQAAAAECQR5AY/disX56/o61sJ/WD8MpsiBEhnMfGF9yjVTsDWf9C5+Qek+/wL6tHPGGHXbw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 14, 4, 28, 24, 436, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffd69b07-8224-4977-9894-c01049322f2f"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("e2903f00-4c67-4547-8c53-a29cc0715437"), new Guid("ffd69b07-8224-4977-9894-c01049322f2f") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2903f00-4c67-4547-8c53-a29cc0715437"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 14, 3, 45, 42, 97, DateTimeKind.Local));
        }
    }
}
