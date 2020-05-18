﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<Phone> Phones { get; set; }
        public DbSet<OrderSeller> OrderSellers { get; set; }
        public DbSet<OrderCustomer> OrderCustomers { get; set; }
        
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OrderSeller orderSeller1 = new OrderSeller { Id = 1, Header = "Header1", Description = "Description1" };
            OrderSeller orderSeller2 = new OrderSeller { Id = 2, Header = "Header3", Description = "Description3" };
            OrderSeller orderSeller3 = new OrderSeller { Id = 3, Header = "Header2", Description = "Description2" };
            modelBuilder.Entity<OrderSeller>().HasData(new OrderSeller[] { orderSeller1, orderSeller2, orderSeller3 });


            Phone phone1 = new Phone { Id = 1, Name = "Phone1", Price = 2000, Manufacturer = "Samsung", Category = "Phone", Screen = 6, CPU = "CPU1", Camera = "Camera1", RAM = 4, Memory = 16, QtySimCard = 2, Charge = 3000, OperationSystem = "Android", OrderSellerId = 1 };
            Phone phone2 = new Phone { Id = 2, Name = "Phone2", Price = 4000, Manufacturer = "Apple", Category = "Phone", Screen = 8, CPU = "CPU2", Camera = "Camera2", RAM = 16, Memory = 64, QtySimCard = 2, Charge = 2500, OperationSystem = "IOS", OrderSellerId = 2 };
            Phone phone3 = new Phone { Id = 3, Name = "Phone3", Price = 3000, Manufacturer = "ASUS", Category = "Phone", Screen = 6.5, CPU = "CPU3", Camera = "Camera3", RAM = 8, Memory = 32, QtySimCard = 2, Charge = 5000, OperationSystem = "Android", OrderSellerId = 3 };



            OrderCustomer orderCustomer1 = new OrderCustomer { Id = 1, Name = "Иван", Surname = "Иванов", Patronymic = "Иванович", Address = "ул.Иванова 9", OrderSellerId=2 };
            OrderCustomer orderCustomer2 = new OrderCustomer { Id = 2, Name = "Василий", Surname = "Васильев", Patronymic = "Васильевич", Address = "ул.Васильева 28", OrderSellerId = 1 };
            OrderCustomer orderCustomer3 = new OrderCustomer { Id = 3, Name = "Петр", Surname = "Петров", Patronymic = "Петрович", Address = "ул.Петрова 55", OrderSellerId = 3 };
            OrderCustomer orderCustomer4 = new OrderCustomer { Id = 4, Name = "Евгений", Surname = "Евгенов", Patronymic = "Евгеньевич", Address = "ул.Евгенова 5", OrderSellerId = 2 };
            OrderCustomer orderCustomer5 = new OrderCustomer { Id = 5, Name = "Юрий", Surname = "Юрьев", Patronymic = "Юрьевич", Address = "ул.Юрьева 30", OrderSellerId = 1 };
            OrderCustomer orderCustomer6 = new OrderCustomer { Id = 6, Name = "Григорий", Surname = "Григорьев", Patronymic = "Григорьевич", Address = "ул.Григорьева 12", OrderSellerId = 3 };

            
            

            modelBuilder.Entity<Phone>().HasData(new Phone[] { phone1, phone2, phone3 });
            modelBuilder.Entity<OrderCustomer>().HasData(new OrderCustomer[] { orderCustomer1, orderCustomer2, orderCustomer3, orderCustomer4, orderCustomer5, orderCustomer6 });
            
            

            //phone1.OrderSellerId = orderSeller1.Id;
            //phone1.OrderSeller = orderSeller1;
            //phone2.OrderSellerId = orderSeller2.Id;
            //phone2.OrderSeller = orderSeller2;
            //phone3.OrderSellerId = orderSeller3.Id;
            //phone3.OrderSeller = orderSeller3;

            //orderCustomer1.OrderSellerId = orderSeller2.Id;
            //orderCustomer1.OrderSeller = orderSeller2;
            //orderCustomer2.OrderSellerId = orderSeller1.Id;
            //orderCustomer2.OrderSeller = orderSeller1;
            //orderCustomer3.OrderSellerId = orderSeller3.Id;
            //orderCustomer3.OrderSeller = orderSeller3;
            //orderCustomer4.OrderSellerId = orderSeller3.Id;
            //orderCustomer4.OrderSeller = orderSeller3;
            //orderCustomer5.OrderSellerId = orderSeller1.Id;
            //orderCustomer5.OrderSeller = orderSeller1;
            //orderCustomer6.OrderSellerId = orderSeller3.Id;
            //orderCustomer6.OrderSeller = orderSeller3;


        }
    }
}