using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class fifteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "Path", "ProductId" },
                values: new object[] { 1, "phone1.jpg", "/images/phone1.jpg", 1 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "Path", "ProductId" },
                values: new object[] { 2, "phone2.jpg", "/images/phone2.jpg", 2 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "Path", "ProductId" },
                values: new object[] { 3, "phone3.jpg", "/images/phone3.jpg", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
