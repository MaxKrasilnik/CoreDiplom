using Microsoft.EntityFrameworkCore.Migrations;

namespace NLayerApp.DAL.Migrations
{
    public partial class fourtyfive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DimensionsWithStand",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resolution",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TV_Screen",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SmartPlatform",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TunerRanges",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeightWithStand",
                table: "Products",
                nullable: true);

            migrationBuilder.InsertData(
                table: "OrderSellers",
                columns: new[] { "Id", "Description", "Header", "UserId" },
                values: new object[] { 4, "Samsung UE24H4070 ‒ компактный телевизор с диагональю 24 дюйма и разрешением 1366x768 точек. Среди оснащения можно обнаружить тюнеры цифрового и аналогового телевидения и наличие USB интерфейса для просмотра фильмов, изображений и прослушивания музыки. Для экономии места устройство может быть закреплено на стену с помощью кронштейна, за что отвечает поддержка стандарта VESA и наличие разъемов для крепления 75x75 мм. Подключать проигрыватели, игровые приставки, ресиверы и другие устройства предоставляется возможным благодаря наличию разъемов HDMI (2 порта), компонентному, композитному и компьютерному VGA. За звук в Samsung UE24H4070 отвечает акустическая система 2.0 общей мощностью в 20 Вт с поддержкой Dolby Digital Plus, а для тех, кто любит смотреть телевизор в наушниках иммется разъем для их подключения.", "Телевизор Samsung UE24H4070AUXUA", 1 });

            migrationBuilder.InsertData(
                table: "OrderSellers",
                columns: new[] { "Id", "Description", "Header", "UserId" },
                values: new object[] { 5, "Xiaomi Mi TV 4S 43' – бюджетный «умный» 4К - телевизор под управлением операционной системы Google Android TV, адресованный искушенным современным пользователям Smart TV.Основной концептуальный упор делает на крайне демократичную стоимость, по сравнению с сопоставимыми решениями. 10 - килограммовая конструкция наделена простым и аккуратным дизайном, а в качестве штатной акустики задействованы 10 - ваттные стереодинамики с поддержкой технологии объемного звучания Dolby Audio.Дисплеем служит 43 - дюймовый LCD - экран с LED - подсветкой, разрешением 3840x2160 пикселей и заявленной поддержкой HDR.", "Телевизор Xiaomi Mi LED TV 4S 43' UHD 4K(L43M5 - 5ARU)", 1 });

            migrationBuilder.InsertData(
                table: "OrderSellers",
                columns: new[] { "Id", "Description", "Header", "UserId" },
                values: new object[] { 6, "Panasonic TX-32FSR500 – бюджетный «умный» телевизор, ориентированный на базовое мультимедийное применение в содействии с современной пользовательской электроникой. К достоинствам телевизора стоит отнести функциональный встроенный тюнер с поддержкой цифровых стандартов эфирного вещания DVB-C, DVB-T2, DVB-S2, а также бортовую акустику в составе двух 10-ваттных динамиков с поддержкой технологии объемного звучания Cinema Suround. 32-дюймовый LCD-экран с LED-подсветкой обладает разрешением 1366x768 пикселей.", "Телевизор Panasonic TX-32FSR500", 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Discriminator", "Manufacturer", "Name", "OrderSellerId", "PriceEnd", "PriceNow", "PriceStart", "QtyEnd", "QtyStart", "DimensionsWithStand", "Resolution", "TV_Screen", "SmartPlatform", "TunerRanges", "WeightWithStand" },
                values: new object[] { 4, "TV", "TV", "Samsung", "Телевизор Samsung UE24H4070AUXUA", 4, 3000, 3150, 3300, 5, 10, "561.8 x 384.2 x 163.8 мм", "1366x768", 24, "Нет", "DVB-C DVB-S2 DVB-T2", "4.1 кг" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Discriminator", "Manufacturer", "Name", "OrderSellerId", "PriceEnd", "PriceNow", "PriceStart", "QtyEnd", "QtyStart", "DimensionsWithStand", "Resolution", "TV_Screen", "SmartPlatform", "TunerRanges", "WeightWithStand" },
                values: new object[] { 5, "TV", "TV", "Xiaomi", "Телевизор Xiaomi Mi LED TV 4S 43' UHD 4K(L43M5 - 5ARU)", 5, 7500, 7850, 8000, 7, 10, "963.3 x 214.6 x 613 мм", "3840x2160", 43, "Android", "DVB-C DVB-T2", "7.26 кг" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Discriminator", "Manufacturer", "Name", "OrderSellerId", "PriceEnd", "PriceNow", "PriceStart", "QtyEnd", "QtyStart", "DimensionsWithStand", "Resolution", "TV_Screen", "SmartPlatform", "TunerRanges", "WeightWithStand" },
                values: new object[] { 6, "TV", "TV", "Panasonic", "Телевизор Panasonic TX-32FSR500", 6, 5500, 5700, 6000, 4, 10, "733 x 481 x 198 мм", "1366x768", 32, "My Home Screen 3.0", "DVB-C DVB-S2 DVB-T DVB-T2", "6 кг" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "Path", "ProductId" },
                values: new object[,]
                {
                    { 17, "tv1_1.jpg", "/images/tv1_1.jpg", 4 },
                    { 31, "tv3_3.jpg", "/images/tv3_3.jpg", 6 },
                    { 30, "tv3_2.jpg", "/images/tv3_2.jpg", 6 },
                    { 29, "tv3_1.jpg", "/images/tv3_1.jpg", 6 },
                    { 28, "tv2_6.jpg", "/images/tv2_6.jpg", 5 },
                    { 27, "tv2_5.jpg", "/images/tv2_5.jpg", 5 },
                    { 26, "tv2_4.jpg", "/images/tv2_4.jpg", 5 },
                    { 32, "tv3_4.jpg", "/images/tv3_4.jpg", 6 },
                    { 25, "tv2_3.jpg", "/images/tv2_3.jpg", 5 },
                    { 23, "tv2_1.jpg", "/images/tv2_1.jpg", 5 },
                    { 22, "tv1_6.jpg", "/images/tv1_6.jpg", 4 },
                    { 21, "tv1_5.jpg", "/images/tv1_5.jpg", 4 },
                    { 20, "tv1_4.jpg", "/images/tv1_4.jpg", 4 },
                    { 19, "tv1_3.jpg", "/images/tv1_3.jpg", 4 },
                    { 18, "tv1_2.jpg", "/images/tv1_2.jpg", 4 },
                    { 24, "tv2_2.jpg", "/images/tv2_2.jpg", 5 },
                    { 33, "tv3_5.jpg", "/images/tv3_5.jpg", 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderSellers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "DimensionsWithStand",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Resolution",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TV_Screen",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SmartPlatform",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TunerRanges",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "WeightWithStand",
                table: "Products");
        }
    }
}
