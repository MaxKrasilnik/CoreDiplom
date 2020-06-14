using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class fourtythree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Header" },
                values: new object[] { "Samsung Galaxy A31 – смартфон среднего ценового сегмента, сочетающий в себе хороший уровень оснащения, емкий аккумулятор и строгий обновленный дизайн. Элегантные цвета корпуса дополнены стильным узором, что прибавляет баллы внешнему виду устройства. В Samsung Galaxy A31 устанавливается 6,4-дюймовый sAMOLED дисплей с разрешением 2400х1080 точек и плотностью пикселей 411 ppi. Достаточную для комфортного повседневного использования производительность обеспечивает 8-ядерный процессор. Основная камера состоит из 4 модулей на 48, 8 и пары по 5 МП. Фронтальная камера установлена в небольшом каплевидном вырезе в экране и оснащается 20 МП модулем. Особенностью Samsung Galaxy A31 является также встроенный в дисплей сканер отпечатков пальцев, а также наличие NFC.", "Мобильный телефон Samsung Galaxy A31 4/128GB Prism Crush White (SM-A315FZWVSEK)" });

            migrationBuilder.UpdateData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Header" },
                values: new object[] { "iPhone 11 нельзя назвать абсолютно новым смартфоном, это прямой потомок iPhone XR. Смартфон изменился внешне очень минимально, габариты с предшественником совпадают полностью. Главным внешним новшеством являются обновленные цветовые решения, но это по-прежнему самый яркий iPhone. Еще одним изменением стало появление второго модуля камеры, теперь к широкоугольному добавился ультраширокоугольный объектив. Это позволит создавать групповые портреты и красивые панорамы. В качестве процессора теперь используется более быстрый и энергоэффективный Apple 13 Bionic. Что касается времени автономной работы, то и здесь компания сделала шаг вперед и смартфон должен работать как минимум на час дольше модели XR.", "Мобильный телефон Apple iPhone 11 128GB PRODUCT Red Официальная гарантия" });

            migrationBuilder.UpdateData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Header" },
                values: new object[] { "Samsung Galaxy M21 – обновленная версия одного из самых сбалансированных решений компании в среднем сегменте. Устройство объединяет в себе элегантный лаконичный дизайн, безрамочное исполнение и хороший уровень оснащения. 6,4-дюймовый Super AMOLED дисплей Samsung Galaxy M21 имеет разрешение 2340х1080 точек. Фронтальная камера на 20- МП установлена в небольшом каплевидном вырезе. Она поддерживает технологию распознавания по лицу. Комфортный для любых задач уровень производительности обеспечивает 8-ядерный процессор Samsung Exynos 7. Основная камера смартфона состоит из трех модулей на 48, 8 и 5 МП. Она способна вести запись видео в разрешении 3840х2160 точек и с высокой частотой до 240 к/с. Важной особенностью Samsung Galaxy M21 является наличие NFC, а также поддержки быстрой зарядки.", "Смартфон Samsung Galaxy M21 4/64GB Green (SM-M215FZGU)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CPU", "Camera", "Charge", "Memory" },
                values: new object[] { "MediaTek MT6768 2.0 ГГц + 1.7 ГГц", "12", 5000, 128 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CPU", "Camera", "Charge", "Memory", "QtySimCard", "RAM" },
                values: new object[] { "Apple A13 Bionic", "20", 3046, 128, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Manufacturer", "CPU", "Camera", "Charge", "Memory", "RAM" },
                values: new object[] { "Samsung", "Samsung Exynos 9611 2.3 ГГц + 1.7 ГГц", "20", 6000, 62, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Header" },
                values: new object[] { "Description1", "Header1" });

            migrationBuilder.UpdateData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Header" },
                values: new object[] { "Description3", "Header3" });

            migrationBuilder.UpdateData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Header" },
                values: new object[] { "Description2", "Header2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CPU", "Camera", "Charge", "Memory" },
                values: new object[] { "CPU1", "Camera1", 3000, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CPU", "Camera", "Charge", "Memory", "QtySimCard", "RAM" },
                values: new object[] { "CPU2", "Camera2", 2500, 64, 2, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Manufacturer", "CPU", "Camera", "Charge", "Memory", "RAM" },
                values: new object[] { "ASUS", "CPU3", "Camera3", 5000, 32, 8 });
        }
    }
}
