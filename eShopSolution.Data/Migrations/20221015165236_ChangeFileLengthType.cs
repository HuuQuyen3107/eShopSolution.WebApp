using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int));

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 15, 23, 52, 35, 649, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffd69b07-8224-4977-9894-c01049322f2f"),
                column: "ConcurrencyStamp",
                value: "260df067-778f-45ae-a723-b552527428eb");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2903f00-4c67-4547-8c53-a29cc0715437"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f01e5e49-7dd1-4ffb-bd1c-7ac11174e1d7", "AQAAAAEAACcQAAAAECTIFlixn46BcbpTdoGedJPa3DKXmfUc1lGcPrJOE6neaWNCMAbmi1TQyWgMA+Wm/Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 15, 13, 12, 36, 652, DateTimeKind.Local));
        }
    }
}
