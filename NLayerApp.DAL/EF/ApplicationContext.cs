using Microsoft.EntityFrameworkCore;
using NLayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DAL.EF
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<TV> TVs { get; set; }
        public DbSet<OrderSeller> OrderSellers { get; set; }
        public DbSet<OrderCustomer> OrderCustomers { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();   // создаем базу данных при первом обращении
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User user1 = new User() { Id = 1, Email = "email1@gmail.com", Password = "Password1!", Role = "User" };
            User user2 = new User() { Id = 2, Email = "email2@gmail.com", Password = "Password2!", Role = "User" };
            User user3 = new User() { Id = 3, Email = "email3@gmail.com", Password = "Password3!", Role = "Admin" };

            modelBuilder.Entity<User>().HasData(new User[] { user1, user2, user3 });


            OrderSeller orderSeller1 = new OrderSeller { Id = 1, Header = "Мобильный телефон Samsung Galaxy A31 4/128GB Prism Crush White (SM-A315FZWVSEK)", Description = "Samsung Galaxy A31 – смартфон среднего ценового сегмента, сочетающий в себе хороший уровень оснащения, емкий аккумулятор и строгий обновленный дизайн. Элегантные цвета корпуса дополнены стильным узором, что прибавляет баллы внешнему виду устройства. В Samsung Galaxy A31 устанавливается 6,4-дюймовый sAMOLED дисплей с разрешением 2400х1080 точек и плотностью пикселей 411 ppi. Достаточную для комфортного повседневного использования производительность обеспечивает 8-ядерный процессор. Основная камера состоит из 4 модулей на 48, 8 и пары по 5 МП. Фронтальная камера установлена в небольшом каплевидном вырезе в экране и оснащается 20 МП модулем. Особенностью Samsung Galaxy A31 является также встроенный в дисплей сканер отпечатков пальцев, а также наличие NFC.", UserId=1};
            OrderSeller orderSeller2 = new OrderSeller { Id = 2, Header = "Мобильный телефон Apple iPhone 11 128GB PRODUCT Red Официальная гарантия", Description = "iPhone 11 нельзя назвать абсолютно новым смартфоном, это прямой потомок iPhone XR. Смартфон изменился внешне очень минимально, габариты с предшественником совпадают полностью. Главным внешним новшеством являются обновленные цветовые решения, но это по-прежнему самый яркий iPhone. Еще одним изменением стало появление второго модуля камеры, теперь к широкоугольному добавился ультраширокоугольный объектив. Это позволит создавать групповые портреты и красивые панорамы. В качестве процессора теперь используется более быстрый и энергоэффективный Apple 13 Bionic. Что касается времени автономной работы, то и здесь компания сделала шаг вперед и смартфон должен работать как минимум на час дольше модели XR.", UserId = 1 };
            OrderSeller orderSeller3 = new OrderSeller { Id = 3, Header = "Смартфон Samsung Galaxy M21 4/64GB Green (SM-M215FZGU)", Description = "Samsung Galaxy M21 – обновленная версия одного из самых сбалансированных решений компании в среднем сегменте. Устройство объединяет в себе элегантный лаконичный дизайн, безрамочное исполнение и хороший уровень оснащения. 6,4-дюймовый Super AMOLED дисплей Samsung Galaxy M21 имеет разрешение 2340х1080 точек. Фронтальная камера на 20- МП установлена в небольшом каплевидном вырезе. Она поддерживает технологию распознавания по лицу. Комфортный для любых задач уровень производительности обеспечивает 8-ядерный процессор Samsung Exynos 7. Основная камера смартфона состоит из трех модулей на 48, 8 и 5 МП. Она способна вести запись видео в разрешении 3840х2160 точек и с высокой частотой до 240 к/с. Важной особенностью Samsung Galaxy M21 является наличие NFC, а также поддержки быстрой зарядки.", UserId = 2 };
            OrderSeller orderSeller4 = new OrderSeller { Id = 4, Header = "Телевизор Samsung UE24H4070AUXUA", Description = "Samsung UE24H4070 ‒ компактный телевизор с диагональю 24 дюйма и разрешением 1366x768 точек. Среди оснащения можно обнаружить тюнеры цифрового и аналогового телевидения и наличие USB интерфейса для просмотра фильмов, изображений и прослушивания музыки. Для экономии места устройство может быть закреплено на стену с помощью кронштейна, за что отвечает поддержка стандарта VESA и наличие разъемов для крепления 75x75 мм. Подключать проигрыватели, игровые приставки, ресиверы и другие устройства предоставляется возможным благодаря наличию разъемов HDMI (2 порта), компонентному, композитному и компьютерному VGA. За звук в Samsung UE24H4070 отвечает акустическая система 2.0 общей мощностью в 20 Вт с поддержкой Dolby Digital Plus, а для тех, кто любит смотреть телевизор в наушниках иммется разъем для их подключения.", UserId = 1 };
            OrderSeller orderSeller5 = new OrderSeller { Id = 5, Header = "Телевизор Xiaomi Mi LED TV 4S 43' UHD 4K(L43M5 - 5ARU)", Description = "Xiaomi Mi TV 4S 43' – бюджетный «умный» 4К - телевизор под управлением операционной системы Google Android TV, адресованный искушенным современным пользователям Smart TV.Основной концептуальный упор делает на крайне демократичную стоимость, по сравнению с сопоставимыми решениями. 10 - килограммовая конструкция наделена простым и аккуратным дизайном, а в качестве штатной акустики задействованы 10 - ваттные стереодинамики с поддержкой технологии объемного звучания Dolby Audio.Дисплеем служит 43 - дюймовый LCD - экран с LED - подсветкой, разрешением 3840x2160 пикселей и заявленной поддержкой HDR.", UserId = 1 };
            OrderSeller orderSeller6 = new OrderSeller { Id = 6, Header = "Телевизор Panasonic TX-32FSR500", Description = "Panasonic TX-32FSR500 – бюджетный «умный» телевизор, ориентированный на базовое мультимедийное применение в содействии с современной пользовательской электроникой. К достоинствам телевизора стоит отнести функциональный встроенный тюнер с поддержкой цифровых стандартов эфирного вещания DVB-C, DVB-T2, DVB-S2, а также бортовую акустику в составе двух 10-ваттных динамиков с поддержкой технологии объемного звучания Cinema Suround. 32-дюймовый LCD-экран с LED-подсветкой обладает разрешением 1366x768 пикселей.", UserId = 2 };

            modelBuilder.Entity<OrderSeller>().HasData(new OrderSeller[] { orderSeller1, orderSeller2, orderSeller3, orderSeller4, orderSeller5, orderSeller6 });


            


            Phone phone1 = new Phone { Id = 1, Name = "Мобильный телефон Samsung Galaxy A31 4/128GB Prism Crush White (SM-A315FZWVSEK)", Manufacturer = "Samsung", Category = "Phone", PriceStart = 6700, PriceNow=6350, PriceEnd=6000, QtyStart=10, QtyEnd=5, Screen = 6, CPU = "MediaTek MT6768 2.0 ГГц + 1.7 ГГц", Camera = "12", RAM = 4, Memory = 128, QtySimCard = 2, Charge = 5000, OperationSystem = "Android", OrderSellerId = 1 };
            Phone phone2 = new Phone { Id = 2, Name = "Мобильный телефон Apple iPhone 11 128GB PRODUCT Red Официальная гарантия", Manufacturer = "Apple", Category = "Phone", PriceStart = 26000, PriceNow = 24200, PriceEnd = 23000, QtyStart=5, QtyEnd=2, Screen = 8, CPU = "Apple A13 Bionic", Camera = "20", RAM = 4, Memory = 128, QtySimCard = 1, Charge = 3046, OperationSystem = "IOS", OrderSellerId = 2 };
            Phone phone3 = new Phone { Id = 3, Name = "Мобильный телефон Samsung Galaxy M21 4/64GB Green (SM-M215FZGUSEK)", Manufacturer = "Samsung", Category = "Phone", PriceStart=6300, PriceNow=6090, PriceEnd=6000, QtyStart=10, QtyEnd=3, Screen = 6.5, CPU = "Samsung Exynos 9611 2.3 ГГц + 1.7 ГГц", Camera = "20", RAM = 4, Memory = 62, QtySimCard = 2, Charge = 6000, OperationSystem = "Android", OrderSellerId = 3 };

            modelBuilder.Entity<Phone>().HasData(new Phone[] { phone1, phone2, phone3 });



            TV tv1 = new TV() { Id = 4, Name = "Телевизор Samsung UE24H4070AUXUA", Manufacturer = "Samsung", Category = "TV", PriceStart = 3300, PriceNow = 3150, PriceEnd = 3000, QtyStart = 10, QtyEnd = 5, OrderSellerId = 4, Screen = 24, Resolution = "1366x768", TunerRanges = "DVB-C DVB-S2 DVB-T2", SmartPlatform = "Нет", DimensionsWithStand = "561.8 x 384.2 x 163.8 мм", WeightWithStand = "4.1 кг" };
            TV tv2 = new TV() { Id = 5, Name = "Телевизор Xiaomi Mi LED TV 4S 43' UHD 4K(L43M5 - 5ARU)", Manufacturer = "Xiaomi", Category = "TV", PriceStart = 8000, PriceNow = 7850, PriceEnd = 7500, QtyStart = 10, QtyEnd = 7, OrderSellerId = 5, Screen = 43, Resolution = "3840x2160", TunerRanges = "DVB-C DVB-T2", SmartPlatform = "Android", DimensionsWithStand = "963.3 x 214.6 x 613 мм", WeightWithStand = "7.26 кг" };
            TV tv3 = new TV() { Id = 6, Name = "Телевизор Panasonic TX-32FSR500", Manufacturer = "Panasonic", Category = "TV", PriceStart = 6000, PriceNow = 5700, PriceEnd = 5500, QtyStart = 10, QtyEnd = 4, OrderSellerId = 6, Screen = 32, Resolution = "1366x768", TunerRanges = "DVB-C DVB-S2 DVB-T DVB-T2", SmartPlatform = "My Home Screen 3.0", DimensionsWithStand = "733 x 481 x 198 мм", WeightWithStand = "6 кг" };

            modelBuilder.Entity<TV>().HasData(new TV[] { tv1, tv2, tv3 });




            OrderCustomer orderCustomer1 = new OrderCustomer { Id = 1, Name = "Иван", Surname = "Иванов", Patronymic = "Иванович", Address = "ул.Иванова 9", ProdId = 1, UserId=1 };
            OrderCustomer orderCustomer2 = new OrderCustomer { Id = 2, Name = "Василий", Surname = "Васильев", Patronymic = "Васильевич", Address = "ул.Васильева 28", ProdId = 1, UserId = 1 };
            OrderCustomer orderCustomer3 = new OrderCustomer { Id = 3, Name = "Петр", Surname = "Петров", Patronymic = "Петрович", Address = "ул.Петрова 55", ProdId = 1, UserId = 1 };
            OrderCustomer orderCustomer4 = new OrderCustomer { Id = 4, Name = "Евгений", Surname = "Евгенов", Patronymic = "Евгеньевич", Address = "ул.Евгенова 5", ProdId = 2, UserId = 1 };
            OrderCustomer orderCustomer5 = new OrderCustomer { Id = 5, Name = "Юрий", Surname = "Юрьев", Patronymic = "Юрьевич", Address = "ул.Юрьева 30", ProdId = 3, UserId = 2 };
            OrderCustomer orderCustomer6 = new OrderCustomer { Id = 6, Name = "Григорий", Surname = "Григорьев", Patronymic = "Григорьевич", Address = "ул.Григорьева 12", ProdId = 3, UserId = 2 };

            modelBuilder.Entity<OrderCustomer>().HasData(new OrderCustomer[] { orderCustomer1, orderCustomer2, orderCustomer3, orderCustomer4, orderCustomer5, orderCustomer6 });


  
            Image image1 = new Image() { Id = 1, Name = "phone1.jpg", Path = "/images/phone1.jpg", ProductId = phone1.Id };
            Image image2 = new Image() { Id = 2, Name = "phone1_1.jpg", Path = "/images/phone1_1.jpg", ProductId = phone1.Id };
            Image image3 = new Image() { Id = 3, Name = "phone1_2.jpg", Path = "/images/phone1_2.jpg", ProductId = phone1.Id };
            Image image4 = new Image() { Id = 4, Name = "phone1_3.jpg", Path = "/images/phone1_3.jpg", ProductId = phone1.Id };
            Image image5 = new Image() { Id = 5, Name = "phone1_4.jpg", Path = "/images/phone1_4.jpg", ProductId = phone1.Id };
            Image image6 = new Image() { Id = 6, Name = "phone1_5.jpg", Path = "/images/phone1_5.jpg", ProductId = phone1.Id };


            Image image7 = new Image() { Id = 7, Name = "phone2.jpg", Path = "/images/phone2.jpg", ProductId = phone2.Id };
            Image image8 = new Image() { Id = 8, Name = "phone2_1.jpg", Path = "/images/phone2_1.jpg", ProductId = phone2.Id };
            Image image9 = new Image() { Id = 9, Name = "phone2_2.jpg", Path = "/images/phone2_2.jpg", ProductId = phone2.Id };
            Image image10 = new Image() { Id = 10, Name = "phone2_3.jpg", Path = "/images/phone2_3.jpg", ProductId = phone2.Id };
            Image image11 = new Image() { Id = 11, Name = "phone2_4.jpg", Path = "/images/phone2_4.jpg", ProductId = phone2.Id };


            Image image12 = new Image() { Id = 12, Name = "phone3.jpg", Path = "/images/phone3.jpg", ProductId = phone3.Id };
            Image image13 = new Image() { Id = 13, Name = "phone3_1.jpg", Path = "/images/phone3_1.jpg", ProductId = phone3.Id };
            Image image14 = new Image() { Id = 14, Name = "phone3_2.jpg", Path = "/images/phone3_2.jpg", ProductId = phone3.Id };
            Image image15 = new Image() { Id = 15, Name = "phone3_3.jpg", Path = "/images/phone3_3.jpg", ProductId = phone3.Id };
            Image image16 = new Image() { Id = 16, Name = "phone3_4.jpg", Path = "/images/phone3_4.jpg", ProductId = phone3.Id };

            Image image17 = new Image() { Id = 17, Name = "tv1_1.jpg", Path = "/images/tv1_1.jpg", ProductId = tv1.Id };
            Image image18 = new Image() { Id = 18, Name = "tv1_2.jpg", Path = "/images/tv1_2.jpg", ProductId = tv1.Id };
            Image image19 = new Image() { Id = 19, Name = "tv1_3.jpg", Path = "/images/tv1_3.jpg", ProductId = tv1.Id };
            Image image20 = new Image() { Id = 20, Name = "tv1_4.jpg", Path = "/images/tv1_4.jpg", ProductId = tv1.Id };
            Image image21 = new Image() { Id = 21, Name = "tv1_5.jpg", Path = "/images/tv1_5.jpg", ProductId = tv1.Id };
            Image image22 = new Image() { Id = 22, Name = "tv1_6.jpg", Path = "/images/tv1_6.jpg", ProductId = tv1.Id };

            Image image23 = new Image() { Id = 23, Name = "tv2_1.jpg", Path = "/images/tv2_1.jpg", ProductId = tv2.Id };
            Image image24 = new Image() { Id = 24, Name = "tv2_2.jpg", Path = "/images/tv2_2.jpg", ProductId = tv2.Id };
            Image image25 = new Image() { Id = 25, Name = "tv2_3.jpg", Path = "/images/tv2_3.jpg", ProductId = tv2.Id };
            Image image26 = new Image() { Id = 26, Name = "tv2_4.jpg", Path = "/images/tv2_4.jpg", ProductId = tv2.Id };
            Image image27 = new Image() { Id = 27, Name = "tv2_5.jpg", Path = "/images/tv2_5.jpg", ProductId = tv2.Id };
            Image image28 = new Image() { Id = 28, Name = "tv2_6.jpg", Path = "/images/tv2_6.jpg", ProductId = tv2.Id };

            Image image29 = new Image() { Id = 29, Name = "tv3_1.jpg", Path = "/images/tv3_1.jpg", ProductId = tv3.Id };
            Image image30 = new Image() { Id = 30, Name = "tv3_2.jpg", Path = "/images/tv3_2.jpg", ProductId = tv3.Id };
            Image image31 = new Image() { Id = 31, Name = "tv3_3.jpg", Path = "/images/tv3_3.jpg", ProductId = tv3.Id };
            Image image32 = new Image() { Id = 32, Name = "tv3_4.jpg", Path = "/images/tv3_4.jpg", ProductId = tv3.Id };
            Image image33 = new Image() { Id = 33, Name = "tv3_5.jpg", Path = "/images/tv3_5.jpg", ProductId = tv3.Id };

            modelBuilder.Entity<Image>().HasData(new Image[] { image1, image2, image3, image4, image5, image6, image7, image8, image9, image10, image11, image12, image13, image14, image15, image16, image17, image18, image19, image20, image21, image22, image23, image24, image25, image26, image27, image28, image29, image30, image31, image32, image33 });
            
            
            
        }
    }
}
