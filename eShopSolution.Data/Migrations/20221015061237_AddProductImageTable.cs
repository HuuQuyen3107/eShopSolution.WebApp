using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeoAlias",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreate = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AddColumn<string>(
                name: "SeoAlias",
                table: "Products",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffd69b07-8224-4977-9894-c01049322f2f"),
                column: "ConcurrencyStamp",
                value: "b6bf27f9-f8a5-4a44-865b-d3e2f4a63eb6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2903f00-4c67-4547-8c53-a29cc0715437"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a135f55-5ade-455a-b94e-73563be965a9", "AQAAAAEAACcQAAAAECQR5AY/disX56/o61sJ/WD8MpsiBEhnMfGF9yjVTsDWf9C5+Qek+/wL6tHPGGHXbw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 10, 14, 4, 28, 24, 436, DateTimeKind.Local));
        }
    }
}
