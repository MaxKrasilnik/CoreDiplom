﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLayerApp.DAL.EF;

namespace NLayerApp.DAL.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200610103624_thirty-one")]
    partial class thirtyone
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NLayerApp.DAL.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "phone1.jpg",
                            Path = "/images/phone1.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "phone1_1.jpg",
                            Path = "/images/phone1_1.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "phone1_2.jpg",
                            Path = "/images/phone1_2.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "phone1_3.jpg",
                            Path = "/images/phone1_3.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "phone1_4.jpg",
                            Path = "/images/phone1_4.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 6,
                            Name = "phone1_5.jpg",
                            Path = "/images/phone1_5.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 7,
                            Name = "phone1_6.jpg",
                            Path = "/images/phone1_6.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 8,
                            Name = "phone2.jpg",
                            Path = "/images/phone2.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "phone2_1.jpg",
                            Path = "/images/phone2_1.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 10,
                            Name = "phone2_2.jpg",
                            Path = "/images/phone2_2.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 11,
                            Name = "phone2_3.jpg",
                            Path = "/images/phone2_3.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 12,
                            Name = "phone2_4.jpg",
                            Path = "/images/phone2_4.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 13,
                            Name = "phone3.jpg",
                            Path = "/images/phone3.jpg",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 14,
                            Name = "phone3_1.jpg",
                            Path = "/images/phone3_1.jpg",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 15,
                            Name = "phone3_2.jpg",
                            Path = "/images/phone3_2.jpg",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 16,
                            Name = "phone3_3.jpg",
                            Path = "/images/phone3_3.jpg",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 17,
                            Name = "phone3_4.jpg",
                            Path = "/images/phone3_4.jpg",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 18,
                            Name = "phone3_5.jpg",
                            Path = "/images/phone3_5.jpg",
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("NLayerApp.DAL.Entities.OrderCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("OrderCustomers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "ул.Иванова 9",
                            Name = "Иван",
                            Patronymic = "Иванович",
                            Surname = "Иванов",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "ул.Васильева 28",
                            Name = "Василий",
                            Patronymic = "Васильевич",
                            Surname = "Васильев",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Address = "ул.Петрова 55",
                            Name = "Петр",
                            Patronymic = "Петрович",
                            Surname = "Петров",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Address = "ул.Евгенова 5",
                            Name = "Евгений",
                            Patronymic = "Евгеньевич",
                            Surname = "Евгенов",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            Address = "ул.Юрьева 30",
                            Name = "Юрий",
                            Patronymic = "Юрьевич",
                            Surname = "Юрьев",
                            UserId = 2
                        },
                        new
                        {
                            Id = 6,
                            Address = "ул.Григорьева 12",
                            Name = "Григорий",
                            Patronymic = "Григорьевич",
                            Surname = "Григорьев",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("NLayerApp.DAL.Entities.OrderSeller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("OrderSellers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description1",
                            Header = "Header1",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description3",
                            Header = "Header3",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description2",
                            Header = "Header2",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("NLayerApp.DAL.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderSellerId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("OrderSellerId")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");
                });

            modelBuilder.Entity("NLayerApp.DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "email1@gmail.com",
                            Password = "Password1!",
                            Role = "User"
                        },
                        new
                        {
                            Id = 2,
                            Email = "email2@gmail.com",
                            Password = "Password2!",
                            Role = "User"
                        },
                        new
                        {
                            Id = 3,
                            Email = "email3@gmail.com",
                            Password = "Password3!",
                            Role = "Admin"
                        });
                });

            modelBuilder.Entity("NLayerApp.DAL.Entities.Phone", b =>
                {
                    b.HasBaseType("NLayerApp.DAL.Entities.Product");

                    b.Property<string>("CPU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Camera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Charge")
                        .HasColumnType("int");

                    b.Property<int>("Memory")
                        .HasColumnType("int");

                    b.Property<string>("OperationSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtySimCard")
                        .HasColumnType("int");

                    b.Property<int>("RAM")
                        .HasColumnType("int");

                    b.Property<double>("Screen")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Phone");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Phone",
                            Manufacturer = "Samsung",
                            Name = "Мобильный телефон Samsung Galaxy A31 4/128GB Prism Crush White (SM-A315FZWVSEK)",
                            OrderSellerId = 1,
                            Price = 6699f,
                            CPU = "CPU1",
                            Camera = "Camera1",
                            Charge = 3000,
                            Memory = 16,
                            OperationSystem = "Android",
                            QtySimCard = 2,
                            RAM = 4,
                            Screen = 6.0
                        },
                        new
                        {
                            Id = 2,
                            Category = "Phone",
                            Manufacturer = "Apple",
                            Name = "Мобильный телефон Apple iPhone 11 128GB PRODUCT Red Официальная гарантия",
                            OrderSellerId = 2,
                            Price = 25999f,
                            CPU = "CPU2",
                            Camera = "Camera2",
                            Charge = 2500,
                            Memory = 64,
                            OperationSystem = "IOS",
                            QtySimCard = 2,
                            RAM = 16,
                            Screen = 8.0
                        },
                        new
                        {
                            Id = 3,
                            Category = "Phone",
                            Manufacturer = "ASUS",
                            Name = "Мобильный телефон Samsung Galaxy M21 4/64GB Green (SM-M215FZGUSEK)",
                            OrderSellerId = 3,
                            Price = 6299f,
                            CPU = "CPU3",
                            Camera = "Camera3",
                            Charge = 5000,
                            Memory = 32,
                            OperationSystem = "Android",
                            QtySimCard = 2,
                            RAM = 8,
                            Screen = 6.5
                        });
                });

            modelBuilder.Entity("NLayerApp.DAL.Entities.Image", b =>
                {
                    b.HasOne("NLayerApp.DAL.Entities.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NLayerApp.DAL.Entities.OrderCustomer", b =>
                {
                    b.HasOne("NLayerApp.DAL.Entities.User", "User")
                        .WithMany("OrderCustomers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NLayerApp.DAL.Entities.OrderSeller", b =>
                {
                    b.HasOne("NLayerApp.DAL.Entities.User", "User")
                        .WithMany("OrderSellers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NLayerApp.DAL.Entities.Product", b =>
                {
                    b.HasOne("NLayerApp.DAL.Entities.OrderSeller", "OrderSeller")
                        .WithOne("Product")
                        .HasForeignKey("NLayerApp.DAL.Entities.Product", "OrderSellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
