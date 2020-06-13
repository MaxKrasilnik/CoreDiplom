using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class fourty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //here
            migrationBuilder.AddColumn<int>(
                name: "ProdId",
                table: "OrderCustomers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProdId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProdId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProdId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProdId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProdId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProdId",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "ProdId",
                table: "OrderCustomers",
                type: "int",
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
    }
}
