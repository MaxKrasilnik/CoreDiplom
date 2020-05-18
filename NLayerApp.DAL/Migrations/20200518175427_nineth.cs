using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class nineth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderSellers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSellers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Patronymic = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    OrderSellerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderCustomers_OrderSellers_OrderSellerId",
                        column: x => x.OrderSellerId,
                        principalTable: "OrderSellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    OrderSellerId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Screen = table.Column<double>(nullable: true),
                    CPU = table.Column<string>(nullable: true),
                    Camera = table.Column<string>(nullable: true),
                    RAM = table.Column<int>(nullable: true),
                    Memory = table.Column<int>(nullable: true),
                    QtySimCard = table.Column<int>(nullable: true),
                    Charge = table.Column<int>(nullable: true),
                    OperationSystem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_OrderSellers_OrderSellerId",
                        column: x => x.OrderSellerId,
                        principalTable: "OrderSellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderCustomers_OrderSellerId",
                table: "OrderCustomers",
                column: "OrderSellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderSellerId",
                table: "Products",
                column: "OrderSellerId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderCustomers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "OrderSellers");
        }
    }
}
