using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class fourtysix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Screen",
                table: "Products",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RAM",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Memory",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone_CPU",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Phone_Memory",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Phone_RAM",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Phone_Screen",
                table: "Products",
                nullable: true);

            migrationBuilder.InsertData(
                table: "OrderSellers",
                columns: new[] { "Id", "Description", "Header", "UserId" },
                values: new object[,]
                {
                    { 7, "Lenovo S145 — это 15.6-дюймовый высокопроизводительный ноутбук, который отлично подойдет для работы и развлечений. Ноутбук оснащен производительным процессором, высокоскоростным модулем Wi-Fi и акустической системой высокого качества. Динамический звук. Приготовьтесь окунуться в мир мультимедийных развлечений.Благодаря качественной аудиосистеме S145 обеспечивает громкое звучание музыки и фильмов. Высокая скорость передачи данных. Ноутбук оборудован разъемом USB 3.1, что позволяет обмениваться данными с другими устройствами со скоростью, которая в 10 раз превышает скорость интерфейсов USB более ранних версий. Интернет на сверхвысоких скоростях. Ноутбук S145 оснащен встроенным модулем Wi - Fi 802.11 ac, который обеспечивает молниеносную скорость для веб - серфинга, воспроизведения потокового видео и загрузки файлов.Скорость передачи данных стандарта Wi - Fi 802.11 ac почти в три раза выше, чем 802.11 b / g / n. Внимание к деталям S145 обладает простым, но в то же время элегантным дизайном.Несмотря на свою компактность, ноутбук может похвастать богатой функциональностью и поддержкой современных интерфейсов, включая USB 3.1, HDMI и SD.", "Ноутбук Lenovo IdeaPad S145-15IGM (81MX002RRA) Granite Black", 1 },
                    { 8, "HP Pavilion Gaming 15 — среднеформатный игровой ноутбук, ориентированный на пользователей, которым нужно мощное и портативное решение. Модель выполнена в обновленном дизайне, соответствующем новой линейке и отличается строгостью и элегантностью. HP Pavilion Gaming 15 оснащается высокопроизводительным процессором Intel Core i7, работающим в паре с дискретным видеоадаптером NVIDIA GeForce GTX950M. В такой конфигурации ноутбук способен справляться с любыми задачами, которые поставит перед ним пользователь. В HP Pavilion Gaming 15 используется качественная IPS матрица, которая обеспечивает отличное качество картинки. Приятным бонусом станет наличие подсветки клавиатуры, что делает возможным игру и работу в темное время суток.", "Ноутбук HP Pavilion Gaming 15-ec0003ua (9RH21EA) Dark Grey Суперцена!!!", 1 },
                    { 9, "ASUS Laptop X571 – это современный ноутбук для ежедневного использования как дома, так и в офисе. Его мощная аппаратная конфигурация, в которую входит процессор Intel, видеокарта NVIDIA GeForce 1650 и до 16 гигабайт оперативной памяти, обеспечит высокую скорость работы любых приложений. В качестве операционной системы на него может устанавливаться Windows 10 Pro. Ноутбук ASUS Laptop X571 обладает современной конфигурацией, которая прекрасно подходит для повседневных дел и развлечений, например для обработки видео или запуска легких игр. В максимальной версии она включает в себя процессор Intel Core i7 девятого поколения, оперативную память объемом 16 ГБ и дискретную видеокарту NVIDIA GeForce GTX 1650.", "Ноутбук Asus Gaming X571GT-BN436 (90NB0NL1-M07160) Star Black Суперцена!!!", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Phone_CPU", "Phone_Memory", "Phone_RAM", "Phone_Screen" },
                values: new object[] { "MediaTek MT6768 2.0 ГГц + 1.7 ГГц", 128, 4, 6.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Phone_CPU", "Phone_Memory", "Phone_RAM", "Phone_Screen" },
                values: new object[] { "Apple A13 Bionic", 128, 4, 8.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Phone_CPU", "Phone_Memory", "Phone_RAM", "Phone_Screen" },
                values: new object[] { "Samsung Exynos 9611 2.3 ГГц + 1.7 ГГц", 62, 4, 6.5 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Discriminator", "Manufacturer", "Name", "OrderSellerId", "PriceEnd", "PriceNow", "PriceStart", "QtyEnd", "QtyStart", "CPU", "Memory", "RAM", "Screen", "Weight" },
                values: new object[] { 7, "Laptop", "Laptop", "Lenovo", "Ноутбук Lenovo IdeaPad S145-15IGM (81MX002RRA) Granite Black", 7, 4500, 4800, 5000, 6, 10, "Двухъядерный Intel Celeron N4000(1.1 - 2.6 ГГц)", "500 ГБ", "4 ГБ", 16, "1.85 кг" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Discriminator", "Manufacturer", "Name", "OrderSellerId", "PriceEnd", "PriceNow", "PriceStart", "QtyEnd", "QtyStart", "CPU", "Memory", "RAM", "Screen", "Weight" },
                values: new object[] { 8, "Laptop", "Laptop", "HP", "Ноутбук HP Pavilion Gaming 15-ec0003ua (9RH21EA) Dark Grey Суперцена!!!", 8, 23000, 23800, 24000, 4, 5, "Четырехъядерный AMD Ryzen 5 3550H (2.1 - 3.7 ГГц)", "500 ГБ", "16 ГБ", 16, "2.25 кг" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Discriminator", "Manufacturer", "Name", "OrderSellerId", "PriceEnd", "PriceNow", "PriceStart", "QtyEnd", "QtyStart", "CPU", "Memory", "RAM", "Screen", "Weight" },
                values: new object[] { 9, "Laptop", "Laptop", "ASUS", "Ноутбук Asus Gaming X571GT-BN436 (90NB0NL1-M07160) Star Black Суперцена!!!", 9, 19000, 20200, 21000, 6, 10, "Четырехъядерный Intel Core i5-8300H (2.3 - 4.0 ГГц)", "256 ГБ", "8 ГБ", 15, "2.14 кг" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "Path", "ProductId" },
                values: new object[,]
                {
                    { 34, "laptop1_1.jpg", "/images/laptop1_1.jpg", 7 },
                    { 35, "laptop1_2.jpg", "/images/laptop1_2.jpg", 7 },
                    { 36, "laptop1_3.jpg", "/images/laptop1_3.jpg", 7 },
                    { 37, "laptop1_4.jpg", "/images/laptop1_4.jpg", 7 },
                    { 38, "laptop2_1.jpg", "/images/laptop2_1.jpg", 8 },
                    { 39, "laptop2_2.jpg", "/images/laptop2_2.jpg", 8 },
                    { 40, "laptop2_3.jpg", "/images/laptop2_3.jpg", 8 },
                    { 41, "laptop2_4.jpg", "/images/laptop2_4.jpg", 8 },
                    { 42, "laptop3_1.jpg", "/images/laptop3_1.jpg", 9 },
                    { 43, "laptop3_2.jpg", "/images/laptop3_2.jpg", 9 },
                    { 44, "laptop3_3.jpg", "/images/laptop3_3.jpg", 9 },
                    { 45, "laptop3_4.jpg", "/images/laptop3_4.jpg", 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Phone_CPU",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Phone_Memory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Phone_RAM",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Phone_Screen",
                table: "Products");

            migrationBuilder.AlterColumn<double>(
                name: "Screen",
                table: "Products",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RAM",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Memory",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CPU", "Memory", "RAM", "Screen" },
                values: new object[] { "MediaTek MT6768 2.0 ГГц + 1.7 ГГц", 128, 4, 6.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CPU", "Memory", "RAM", "Screen" },
                values: new object[] { "Apple A13 Bionic", 128, 4, 8.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CPU", "Memory", "RAM", "Screen" },
                values: new object[] { "Samsung Exynos 9611 2.3 ГГц + 1.7 ГГц", 62, 4, 6.5 });
        }
    }
}
