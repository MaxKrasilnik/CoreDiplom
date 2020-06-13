using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class twentyOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderCustomers_OrderSellers_OrderSellerId",
                table: "OrderCustomers");

            migrationBuilder.DropIndex(
                name: "IX_OrderCustomers_OrderSellerId",
                table: "OrderCustomers");

            migrationBuilder.DropColumn(
                name: "OrderSellerId",
                table: "OrderCustomers");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "OrderSellers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "OrderCustomers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Role" },
                values: new object[,]
                {
                    { 1, "email1@gmail.com", "Password1!", "Seller" },
                    { 2, "email2@gmail.com", "Password2!", "Seller" },
                    { 3, "email3@gmail.com", "Password3!", "Customer" },
                    { 4, "email4@gmail.com", "Password4!", "Customer" },
                    { 5, "email5@gmail.com", "Password5!", "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_OrderSellers_UserId",
                table: "OrderSellers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCustomers_UserId",
                table: "OrderCustomers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderCustomers_Users_UserId",
                table: "OrderCustomers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderSellers_Users_UserId",
                table: "OrderSellers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderCustomers_Users_UserId",
                table: "OrderCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderSellers_Users_UserId",
                table: "OrderSellers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_OrderSellers_UserId",
                table: "OrderSellers");

            migrationBuilder.DropIndex(
                name: "IX_OrderCustomers_UserId",
                table: "OrderCustomers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "OrderSellers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "OrderCustomers");

            migrationBuilder.AddColumn<int>(
                name: "OrderSellerId",
                table: "OrderCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderSellerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderSellerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderSellerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderSellerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderSellerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderCustomers",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderSellerId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_OrderCustomers_OrderSellerId",
                table: "OrderCustomers",
                column: "OrderSellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderCustomers_OrderSellers_OrderSellerId",
                table: "OrderCustomers",
                column: "OrderSellerId",
                principalTable: "OrderSellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
