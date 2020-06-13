using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class twentyThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "Path", "ProductId" },
                values: new object[,]
                {
                    { 4, "phone1_1.jpg", "/images/phone1_1.jpg", 1 },
                    { 5, "phone1_2.jpg", "/images/phone1_2.jpg", 1 },
                    { 6, "phone1_3.jpg", "/images/phone1_3.jpg", 1 },
                    { 7, "phone1_4.jpg", "/images/phone1_4.jpg", 1 },
                    { 8, "phone1_5.jpg", "/images/phone1_5.jpg", 1 },
                    { 9, "phone1_6.jpg", "/images/phone1_6.jpg", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
