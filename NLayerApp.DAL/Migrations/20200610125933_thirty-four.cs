using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class thirtyfour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "PriceEnd",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PriceNow",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PriceStart",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QtyEnd",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QtyStart",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Timer",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PriceEnd", "PriceNow", "PriceStart", "QtyEnd", "QtyStart", "Timer" },
                values: new object[] { 6000, 6350, 6700, 5, 10, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PriceEnd", "PriceNow", "PriceStart", "QtyEnd", "QtyStart", "Timer" },
                values: new object[] { 23000, 24200, 26000, 2, 5, new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PriceEnd", "PriceNow", "PriceStart", "QtyEnd", "QtyStart", "Timer" },
                values: new object[] { 6000, 6090, 6300, 3, 10, new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceEnd",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PriceNow",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PriceStart",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "QtyEnd",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "QtyStart",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Timer",
                table: "Products");

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Products",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 6699f);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 25999f);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 6299f);
        }
    }
}
