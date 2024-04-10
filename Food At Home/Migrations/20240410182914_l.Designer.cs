﻿// <auto-generated />
using System;
using Food_At_Home.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Food_At_Home.Migrations
{
    [DbContext(typeof(FoodDbContext))]
    [Migration("20240410182914_l")]
    partial class l
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Food_At_Home.Data.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e4f042b4-52d4-43fc-bfb2-53102b11b719"),
                            Name = "Appetizers"
                        },
                        new
                        {
                            Id = new Guid("cbc7df0c-83f8-4ccd-acc8-d0bea62d0b33"),
                            Name = "Pizzas"
                        },
                        new
                        {
                            Id = new Guid("87f0373e-6d3d-468d-8989-9894937d6517"),
                            Name = "Burgers"
                        },
                        new
                        {
                            Id = new Guid("adf04d8f-4d96-4180-a7cd-19053a23bc81"),
                            Name = "Salads"
                        },
                        new
                        {
                            Id = new Guid("c0a8af9e-feaf-46d6-92e7-5f44592947e0"),
                            Name = "Drinks"
                        },
                        new
                        {
                            Id = new Guid("5c769ba4-1b92-496d-b18d-2bbde73e6ba1"),
                            Name = "Desserts"
                        });
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5646fe32-cf59-45db-b27d-9ddb76d0b8d6"),
                            UserId = new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d")
                        });
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Dish", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeliveryTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.OrderDish", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DishId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "DishId");

                    b.HasIndex("DishId");

                    b.ToTable("OrderDishes");
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<string>("CardHolder")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(19)
                        .HasColumnType("nvarchar(19)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SecurityCode")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ce604d6e-1a66-4059-9777-388cbc34ef84"),
                            Description = "Welcome to Dominos Pizza! Where every meal is a journey of flavors and every moment is savored. We're delighted to have you dine with us today.  ",
                            UserId = new Guid("b7892962-0426-48de-bd62-8ca55ebe930e")
                        });
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                            AccessFailedCount = 0,
                            Address = "Mazalat 16",
                            City = "Kazanlak",
                            ConcurrencyStamp = "ac8c6835-9bee-4533-a23f-48832e168d13",
                            Email = "radostin1@abv.bg",
                            EmailConfirmed = false,
                            ImageUrl = "https://res.cloudinary.com/dqtuni8ed/image/upload/v1712767712/xlnkbydge1fm49l1lvto.jpg",
                            LockoutEnabled = false,
                            Name = "Radostin Dimitrov",
                            NormalizedEmail = "RADOSTIN1@ABV.BG",
                            NormalizedUserName = "RADOSTIN1",
                            PasswordHash = "AQAAAAEAACcQAAAAEIt1l548cz99ym0EQN3wfkX1c6PIzG6e0DxvpvbWye0Gc1DunEKy7eV4Fw4tTz38ug==",
                            PhoneNumber = "0877311440",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "328dc6fb-4fac-4fa4-88bc-956bf21c442c",
                            TwoFactorEnabled = false,
                            UserName = "radostin1"
                        },
                        new
                        {
                            Id = new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                            AccessFailedCount = 0,
                            Address = "Al. Batenberg 46",
                            City = "Kazanlak",
                            ConcurrencyStamp = "cd9e9428-015a-4b25-b6fe-78e54d3db512",
                            Email = "dominos@abv.bg",
                            EmailConfirmed = false,
                            ImageUrl = "https://res.cloudinary.com/dqtuni8ed/image/upload/v1712766785/cu4hlsiiqarbuiejvc5g.png",
                            LockoutEnabled = false,
                            Name = "Domino's Pizza",
                            NormalizedEmail = "DOMINOS@ABV.BG",
                            NormalizedUserName = "DOMINOS",
                            PasswordHash = "AQAAAAEAACcQAAAAEK1nwFbU7X6qdLofnLGTcr84GqkWdpeHsXebtWohfkI8YRb6Vv7Btywv4gSGZ/QDXw==",
                            PhoneNumber = "0882759837",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "95af92fb-0595-46af-ad06-0ebd9af7d744",
                            TwoFactorEnabled = false,
                            UserName = "dominos"
                        },
                        new
                        {
                            Id = new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                            AccessFailedCount = 0,
                            Address = "6-ti Septemvri 9",
                            City = "Kazanlak",
                            ConcurrencyStamp = "a08dd00f-c126-48c9-a54d-5492cf11a20b",
                            Email = "admin@abv.bg",
                            EmailConfirmed = false,
                            ImageUrl = "https://res.cloudinary.com/dqtuni8ed/image/upload/v1712767540/k1i32lmyp6du5abwwyot.jpg",
                            LockoutEnabled = false,
                            Name = "Admin Account",
                            NormalizedEmail = "ADMIN@ABV.BG",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEJN6EjhfZBGmOJp3+CEZF7pzTiAKCZ6rhlZv5h0sG+zW3kReBbosR4owlMe6TLKAqA==",
                            PhoneNumber = "0891231234",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8bcd7f3d-4767-4a23-86b3-405ccfd2a355",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                            ConcurrencyStamp = "57d6a8ba-f624-44a8-ad30-bc0ff01092d9",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                            ConcurrencyStamp = "3e7d64d8-a2a8-479c-a985-6acb9e3cdc37",
                            Name = "Restaurant",
                            NormalizedName = "RESTAURANT"
                        },
                        new
                        {
                            Id = new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                            ConcurrencyStamp = "178f906e-0d4b-4fdf-93f5-efc722efc73b",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                            RoleId = new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41")
                        },
                        new
                        {
                            UserId = new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                            RoleId = new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f")
                        },
                        new
                        {
                            UserId = new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                            RoleId = new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Customer", b =>
                {
                    b.HasOne("Food_At_Home.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Dish", b =>
                {
                    b.HasOne("Food_At_Home.Data.Models.Category", "Category")
                        .WithMany("Dishes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Food_At_Home.Data.Models.Restaurant", "Restaurant")
                        .WithMany("Menu")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Order", b =>
                {
                    b.HasOne("Food_At_Home.Data.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Food_At_Home.Data.Models.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId");

                    b.HasOne("Food_At_Home.Data.Models.Restaurant", "Restaurant")
                        .WithMany("Orders")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Payment");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.OrderDish", b =>
                {
                    b.HasOne("Food_At_Home.Data.Models.Dish", "Dish")
                        .WithMany("Orders")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Food_At_Home.Data.Models.Order", "Order")
                        .WithMany("Dishes")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Payment", b =>
                {
                    b.HasOne("Food_At_Home.Data.Models.Customer", "Customer")
                        .WithMany("Payments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Food_At_Home.Data.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Restaurant", b =>
                {
                    b.HasOne("Food_At_Home.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Food_At_Home.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Food_At_Home.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Food_At_Home.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Food_At_Home.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Category", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Customer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Dish", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Order", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("Food_At_Home.Data.Models.Restaurant", b =>
                {
                    b.Navigation("Menu");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
