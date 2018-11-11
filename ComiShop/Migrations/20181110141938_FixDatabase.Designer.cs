﻿// <auto-generated />
using System;
using ComiShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComiShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181110141938_FixDatabase")]
    partial class FixDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ComiShop.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDes")
                        .HasMaxLength(50);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<Guid>("UniqueId");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new { Id = 1, CategoryDes = "Tiểu thuyết nổi tiếng", CategoryName = "Sách", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("cb966ed6-29b6-4bfc-ae6c-c583d792e528") },
                        new { Id = 2, CategoryDes = "Quần áo", CategoryName = "Quần áo", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("b2fd64a9-f8f4-4b05-a27c-cc465fd46a58") }
                    );
                });

            modelBuilder.Entity("ComiShop.Data.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Context");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ProductId");

                    b.Property<Guid>("UniqueId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ProductId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("ComiShop.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575", ConcurrencyStamp = "8447b005-221d-4755-9ec0-3599fc5efe5d", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "admin", NormalizedName = "admin" }
                    );
                });

            modelBuilder.Entity("ComiShop.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("BankAccount")
                        .HasMaxLength(20);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<int>("CustomerType")
                        .HasMaxLength(10);

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<int?>("PersonInfoId");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PersonInfoId");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575", AccessFailedCount = 0, ConcurrencyStamp = "00e53f3b-4b73-4469-8c18-5348dd96df06", CustomerType = 0, Email = "admin@gmail.com", EmailConfirmed = false, LockoutEnabled = true, NormalizedEmail = "admin@gmail.com", NormalizedUserName = "admin@gmail.com", PasswordHash = "AQAAAAEAACcQAAAAEI8ZjVr5k0rSvi5vPVSwg1Qes5/HGSO06WvZ5WJP1XT8nvtRWaK6MwEXjL+7t8eNTQ==", PhoneNumberConfirmed = false, SecurityStamp = "52f05ef3-5613-4f98-bdb4-f3c343141e08", TwoFactorEnabled = false, UserName = "admin@gmail.com" }
                    );
                });

            modelBuilder.Entity("ComiShop.PersonInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("District")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasMaxLength(15);

                    b.Property<string>("Gender")
                        .HasMaxLength(5);

                    b.Property<string>("LastName")
                        .HasMaxLength(15);

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Street")
                        .HasMaxLength(50);

                    b.Property<Guid>("UniqueId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("PersonInfo");

                    b.HasData(
                        new { Id = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Meo", LastName = "Meo", ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("43d59a79-0930-49c9-a903-42a8ae580631"), UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                    );
                });

            modelBuilder.Entity("ComiShop.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DesDetail")
                        .HasMaxLength(50);

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("ProductDes")
                        .HasMaxLength(50);

                    b.Property<string>("ProductName")
                        .HasMaxLength(50);

                    b.Property<int?>("Quantity");

                    b.Property<Guid>("UniqueId");

                    b.Property<double?>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new { Id = 1, CategoryId = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ProductDes = "Kinh điển", ProductName = "Cuốn theo chiều gió", Quantity = 5, UniqueId = new Guid("3328cb12-e85f-494a-a571-992765837498"), UnitPrice = 50.0 },
                        new { Id = 2, CategoryId = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ProductDes = "Việt Nam", ProductName = "Mắt biếc", Quantity = 12, UniqueId = new Guid("9a1bb2e7-5d4d-42cf-bb62-4db20b612072"), UnitPrice = 60.0 },
                        new { Id = 3, CategoryId = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ProductDes = "Việt Nam", ProductName = "Sơ mi", Quantity = 11, UniqueId = new Guid("14cb7140-d284-49ff-994f-acea95cadac4"), UnitPrice = 60.0 },
                        new { Id = 4, CategoryId = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ProductDes = "Việt Nam", ProductName = "Đầm", Quantity = 22, UniqueId = new Guid("8b51d174-cd30-4677-93a4-c74a35f64ca3"), UnitPrice = 70.0 }
                    );
                });

            modelBuilder.Entity("ComiShop.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ProductId");

                    b.Property<string>("ProductImage")
                        .HasMaxLength(50);

                    b.Property<Guid>("UniqueId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductDetail");

                    b.HasData(
                        new { Id = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ProductId = 1, ProductImage = "i1.jpg", UniqueId = new Guid("2760cf56-cbe1-4452-bfc5-58a1211cff2c") },
                        new { Id = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ProductId = 2, ProductImage = "i10.jpg", UniqueId = new Guid("aa17caa3-6b4c-44a5-916c-256a5740dbea") },
                        new { Id = 3, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ProductId = 3, ProductImage = "i12.jpg", UniqueId = new Guid("6e8d0cab-88c4-4b1c-ab7c-8bf5a6127fb5") },
                        new { Id = 4, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ProductId = 4, ProductImage = "i11.jpg", UniqueId = new Guid("9d23f0cd-4328-4b28-964e-f3231fca9c9c") }
                    );
                });

            modelBuilder.Entity("ComiShop.ReceiveProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("SaleId");

                    b.Property<string>("ShipToAddress")
                        .HasMaxLength(50);

                    b.Property<string>("ShipToCity")
                        .HasMaxLength(50);

                    b.Property<string>("ShipToCountry")
                        .HasMaxLength(50);

                    b.Property<string>("ShipToDistrict")
                        .HasMaxLength(50);

                    b.Property<string>("ShipToName")
                        .HasMaxLength(30);

                    b.Property<string>("ShipToPhone")
                        .HasMaxLength(18);

                    b.Property<string>("ShipToStreet")
                        .HasMaxLength(50);

                    b.Property<Guid>("UniqueId");

                    b.HasKey("Id");

                    b.ToTable("ReceiveProduct");

                    b.HasData(
                        new { Id = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), SaleId = 1, ShipToName = "Ichi", ShipToPhone = "0888888888", UniqueId = new Guid("45a2980e-7e1c-498c-8f0a-6597eda54dd0") },
                        new { Id = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), SaleId = 2, ShipToName = "Gau Gau", ShipToPhone = "094464467", UniqueId = new Guid("c3f020c4-8cf6-4fe2-993a-5523f55bc4f5") }
                    );
                });

            modelBuilder.Entity("ComiShop.SaleOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("date");

                    b.Property<string>("OrderStatus")
                        .HasMaxLength(20);

                    b.Property<int?>("ReceiveProductId");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("date");

                    b.Property<int>("ShipperId");

                    b.Property<double?>("TotalPrice");

                    b.Property<Guid>("UniqueId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ReceiveProductId");

                    b.HasIndex("ShipperId");

                    b.ToTable("SaleOrder");

                    b.HasData(
                        new { Id = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), OrderDate = new DateTime(2018, 11, 10, 21, 19, 38, 306, DateTimeKind.Local), ShipperId = 1, TotalPrice = 50.0, UniqueId = new Guid("d5229d71-6e5d-4d91-8729-71046b34b239"), UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                        new { Id = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), OrderDate = new DateTime(2018, 11, 10, 21, 19, 38, 307, DateTimeKind.Local), ShipperId = 1, TotalPrice = 120.0, UniqueId = new Guid("d40567d7-86b9-422d-96bd-f95dd88beed7"), UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                    );
                });

            modelBuilder.Entity("ComiShop.SaleOrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<int?>("Discount");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ProductId");

                    b.Property<int?>("Quantity");

                    b.Property<int>("SaleOrderId");

                    b.Property<Guid>("UniqueId");

                    b.Property<double?>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleOrderId");

                    b.ToTable("SaleOrderDetail");

                    b.HasData(
                        new { Id = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ProductId = 1, Quantity = 1, SaleOrderId = 1, UniqueId = new Guid("6a2408f3-111a-47f4-adbe-8351ed385cd9"), UnitPrice = 50.0 },
                        new { Id = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ProductId = 3, Quantity = 2, SaleOrderId = 2, UniqueId = new Guid("c65389e1-426e-4ed7-a4f6-69780295b645"), UnitPrice = 60.0 }
                    );
                });

            modelBuilder.Entity("ComiShop.Shipper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .HasMaxLength(20);

                    b.Property<string>("ContactName")
                        .HasMaxLength(20);

                    b.Property<string>("ContactPhone")
                        .HasMaxLength(18);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<Guid>("UniqueId");

                    b.HasKey("Id");

                    b.ToTable("Shipper");

                    b.HasData(
                        new { Id = 1, ContactName = "Anga", ContactPhone = "094123321", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("1b54aeed-4e86-4b28-a629-ffebbe288dca") },
                        new { Id = 2, ContactName = "Husky", ContactPhone = "037864457", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("a1853a48-7ae0-45a3-abf1-bac47b171a8b") }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new { UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575", RoleId = "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ComiShop.Data.Entities.Comment", b =>
                {
                    b.HasOne("ComiShop.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Comments")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ComiShop.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ComiShop.Models.ApplicationUser", b =>
                {
                    b.HasOne("ComiShop.PersonInfo", "PersonInfo")
                        .WithMany()
                        .HasForeignKey("PersonInfoId");
                });

            modelBuilder.Entity("ComiShop.Product", b =>
                {
                    b.HasOne("ComiShop.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ComiShop.ProductDetail", b =>
                {
                    b.HasOne("ComiShop.Product", "Product")
                        .WithOne("ProductDetail")
                        .HasForeignKey("ComiShop.ProductDetail", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ComiShop.SaleOrder", b =>
                {
                    b.HasOne("ComiShop.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("SaleOrders")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ComiShop.ReceiveProduct", "ReceiveProduct")
                        .WithMany()
                        .HasForeignKey("ReceiveProductId");

                    b.HasOne("ComiShop.Shipper", "Shipper")
                        .WithMany("SaleOrders")
                        .HasForeignKey("ShipperId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ComiShop.SaleOrderDetail", b =>
                {
                    b.HasOne("ComiShop.Product", "Product")
                        .WithMany("SaleOrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ComiShop.SaleOrder", "SaleOrder")
                        .WithMany("SaleOrderDetails")
                        .HasForeignKey("SaleOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("ComiShop.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ComiShop.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ComiShop.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("ComiShop.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ComiShop.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ComiShop.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}