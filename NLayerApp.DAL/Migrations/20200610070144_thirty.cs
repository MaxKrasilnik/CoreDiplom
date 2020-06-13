using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class thirty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "Path", "ProductId" },
                values: new object[,]
                {
                    { 10, "phone2_2.jpg", "/images/phone2_2.jpg", 2 },
                    { 11, "phone2_3.jpg", "/images/phone2_3.jpg", 2 },
                    { 12, "phone2_4.jpg", "/images/phone2_4.jpg", 2 },
                    { 13, "phone3.jpg", "/images/phone3.jpg", 3 },
                    { 14, "phone3_1.jpg", "/images/phone3_1.jpg", 3 },
                    { 15, "phone3_2.jpg", "/images/phone3_2.jpg", 3 },
                    { 16, "phone3_3.jpg", "/images/phone3_3.jpg", 3 },
                    { 17, "phone3_4.jpg", "/images/phone3_4.jpg", 3 },
                    { 18, "phone3_5.jpg", "/images/phone3_5.jpg", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
