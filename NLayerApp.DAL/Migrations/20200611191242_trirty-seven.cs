using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class trirtyseven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderSelId",
                table: "OrderCustomers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderSelId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderSelId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderSelId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderSelId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderSelId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderSelId",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderSelId",
                table: "OrderCustomers");
        }
    }
}
