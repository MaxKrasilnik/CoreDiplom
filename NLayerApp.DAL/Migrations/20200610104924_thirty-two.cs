using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class thirtytwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Path", "ProductId" },
                values: new object[] { "phone2.jpg", "/images/phone2.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone2_1.jpg", "/images/phone2_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone2_2.jpg", "/images/phone2_2.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone2_3.jpg", "/images/phone2_3.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone2_4.jpg", "/images/phone2_4.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Path", "ProductId" },
                values: new object[] { "phone3.jpg", "/images/phone3.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone3_1.jpg", "/images/phone3_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone3_2.jpg", "/images/phone3_2.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone3_3.jpg", "/images/phone3_3.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone3_4.jpg", "/images/phone3_4.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Path", "ProductId" },
                values: new object[] { "phone1_6.jpg", "/images/phone1_6.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone2.jpg", "/images/phone2.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone2_1.jpg", "/images/phone2_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone2_2.jpg", "/images/phone2_2.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone2_3.jpg", "/images/phone2_3.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Path", "ProductId" },
                values: new object[] { "phone2_4.jpg", "/images/phone2_4.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone3.jpg", "/images/phone3.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone3_1.jpg", "/images/phone3_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone3_2.jpg", "/images/phone3_2.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone3_3.jpg", "/images/phone3_3.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "Path", "ProductId" },
                values: new object[,]
                {
                    { 17, "phone3_4.jpg", "/images/phone3_4.jpg", 3 },
                    { 18, "phone3_5.jpg", "/images/phone3_5.jpg", 3 }
                });
        }
    }
}
