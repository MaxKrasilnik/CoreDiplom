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


            OrderSeller orderSeller1 = new OrderSeller { Id = 1, Header = "Header1", Description = "Description1", UserId=1};
            OrderSeller orderSeller2 = new OrderSeller { Id = 2, Header = "Header3", Description = "Description3", UserId = 1 };
            OrderSeller orderSeller3 = new OrderSeller { Id = 3, Header = "Header2", Description = "Description2", UserId = 2 };

            modelBuilder.Entity<OrderSeller>().HasData(new OrderSeller[] { orderSeller1, orderSeller2, orderSeller3 });


            


            Phone phone1 = new Phone { Id = 1, Name = "Мобильный телефон Samsung Galaxy A31 4/128GB Prism Crush White (SM-A315FZWVSEK)", Manufacturer = "Samsung", Category = "Phone", PriceStart = 6700, PriceNow=6350, PriceEnd=6000, QtyStart=10, QtyEnd=5, Screen = 6, CPU = "CPU1", Camera = "Camera1", RAM = 4, Memory = 16, QtySimCard = 2, Charge = 3000, OperationSystem = "Android", OrderSellerId = 1 };
            Phone phone2 = new Phone { Id = 2, Name = "Мобильный телефон Apple iPhone 11 128GB PRODUCT Red Официальная гарантия", Manufacturer = "Apple", Category = "Phone", PriceStart = 26000, PriceNow = 24200, PriceEnd = 23000, QtyStart=5, QtyEnd=2, Screen = 8, CPU = "CPU2", Camera = "Camera2", RAM = 16, Memory = 64, QtySimCard = 2, Charge = 2500, OperationSystem = "IOS", OrderSellerId = 2 };
            Phone phone3 = new Phone { Id = 3, Name = "Мобильный телефон Samsung Galaxy M21 4/64GB Green (SM-M215FZGUSEK)", Manufacturer = "ASUS", Category = "Phone", PriceStart=6300, PriceNow=6090, PriceEnd=6000, QtyStart=10, QtyEnd=3, Screen = 6.5, CPU = "CPU3", Camera = "Camera3", RAM = 8, Memory = 32, QtySimCard = 2, Charge = 5000, OperationSystem = "Android", OrderSellerId = 3 };

            modelBuilder.Entity<Phone>().HasData(new Phone[] { phone1, phone2, phone3 });


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


            modelBuilder.Entity<Image>().HasData(new Image[] { image1, image2, image3, image4, image5, image6, image7, image8, image9, image10, image11, image12, image13, image14, image15, image16 });
            
            
            
        }
    }
}
