using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class twentysix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Path", "ProductId" },
                values: new object[] { "phone1_1.jpg", "/images/phone1_1.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Path", "ProductId" },
                values: new object[] { "phone1_2.jpg", "/images/phone1_2.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone1_3.jpg", "/images/phone1_3.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone1_4.jpg", "/images/phone1_4.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone1_5.jpg", "/images/phone1_5.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone1_6.jpg", "/images/phone1_6.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Path", "ProductId" },
                values: new object[] { "phone2.jpg", "/images/phone2.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone2_1.jpg", "/images/phone2_1.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Path", "ProductId" },
                values: new object[] { "phone2.jpg", "/images/phone2.jpg", 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Path", "ProductId" },
                values: new object[] { "phone3.jpg", "/images/phone3.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone1_1.jpg", "/images/phone1_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone1_2.jpg", "/images/phone1_2.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone1_3.jpg", "/images/phone1_3.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone1_4.jpg", "/images/phone1_4.jpg" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Path", "ProductId" },
                values: new object[] { "phone1_5.jpg", "/images/phone1_5.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Path" },
                values: new object[] { "phone1_6.jpg", "/images/phone1_6.jpg" });
        }
    }
}
