using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class UpdateASPNETCORE31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffd69b07-8224-4977-9894-c01049322f2f"),
                column: "ConcurrencyStamp",
                value: "2620e948-25b4-4cf2-841c-a51b2e434499");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2903f00-4c67-4547-8c53-a29cc0715437"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "90d4d2b9-ff6e-4b3a-b87f-0484df2b2e9e", "AQAAAAEAACcQAAAAELwCLUbwxMYI1I8AmclvXk9bcUY2ZzYq++9F2Pst6QuQfxrUnzmmpynWkOgAptntlw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 16, 15, 35, 31, 161, DateTimeKind.Local).AddTicks(5309));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffd69b07-8224-4977-9894-c01049322f2f"),
                column: "ConcurrencyStamp",
                value: "7cea9414-e9c2-4842-a30a-a54ec3b3c567");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2903f00-4c67-4547-8c53-a29cc0715437"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e7194a8-d0bd-4211-b9e4-4bc697753142", "AQAAAAEAACcQAAAAEA6ymPiKhF+Fs8rC2p4v3ErnDekmvoyL+NfcYJS0JzSn/vLiSf/7nsNda1+sS5a6zg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 15, 23, 52, 35, 649, DateTimeKind.Local));
        }
    }
}
