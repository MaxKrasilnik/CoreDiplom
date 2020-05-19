using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class thrirteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OrderSellers",
                columns: new[] { "Id", "Description", "Header" },
                values: new object[] { 1, "Description1", "Header1" });

            migrationBuilder.InsertData(
                table: "OrderSellers",
                columns: new[] { "Id", "Description", "Header" },
                values: new object[] { 2, "Description3", "Header3" });

            migrationBuilder.InsertData(
                table: "OrderSellers",
                columns: new[] { "Id", "Description", "Header" },
                values: new object[] { 3, "Description2", "Header2" });

            migrationBuilder.InsertData(
                table: "OrderCustomers",
                columns: new[] { "Id", "Address", "Name", "OrderSellerId", "Patronymic", "Surname" },
                values: new object[,]
                {
                    { 2, "ул.Васильева 28", "Василий", 1, "Васильевич", "Васильев" },
                    { 5, "ул.Юрьева 30", "Юрий", 1, "Юрьевич", "Юрьев" },
                    { 1, "ул.Иванова 9", "Иван", 2, "Иванович", "Иванов" },
                    { 4, "ул.Евгенова 5", "Евгений", 2, "Евгеньевич", "Евгенов" },
                    { 3, "ул.Петрова 55", "Петр", 3, "Петрович", "Петров" },
                    { 6, "ул.Григорьева 12", "Григорий", 3, "Григорьевич", "Григорьев" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Discriminator", "Manufacturer", "Name", "OrderSellerId", "Price", "CPU", "Camera", "Charge", "Memory", "OperationSystem", "QtySimCard", "RAM", "Screen" },
                values: new object[,]
                {
                    { 1, "Phone", "Phone", "Samsung", "Phone1", 1, 2000f, "CPU1", "Camera1", 3000, 16, "Android", 2, 4, 6.0 },
                    { 2, "Phone", "Phone", "Apple", "Phone2", 2, 4000f, "CPU2", "Camera2", 2500, 64, "IOS", 2, 16, 8.0 },
                    { 3, "Phone", "Phone", "ASUS", "Phone3", 3, 3000f, "CPU3", "Camera3", 5000, 32, "Android", 2, 8, 6.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
