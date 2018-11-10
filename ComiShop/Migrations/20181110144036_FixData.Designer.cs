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
    [Migration("20181110144036_FixData")]
    partial class FixData
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
                        new { Id = 1, CategoryDes = "Tiểu thuyết nổi tiếng", CategoryName = "Sách", CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 536, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 536, DateTimeKind.Local), UniqueId = new Guid("0daa6bf9-d18f-43fa-b231-dee8fe5a5c33") },
                        new { Id = 2, CategoryDes = "Quần áo", CategoryName = "Quần áo", CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), UniqueId = new Guid("59570ab9-91fb-4323-aa4e-9d57f54a1d84") }
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
                        new { Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575", ConcurrencyStamp = "6db04c14-e738-45f9-bb6a-6806d7aeadc3", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "admin", NormalizedName = "admin" }
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
                        new { Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575", AccessFailedCount = 0, ConcurrencyStamp = "e8d9a644-5103-459e-8092-73bc060b4420", CustomerType = 0, Email = "admin@gmail.com", EmailConfirmed = false, LockoutEnabled = true, NormalizedEmail = "admin@gmail.com", NormalizedUserName = "admin@gmail.com", PasswordHash = "AQAAAAEAACcQAAAAEEWYuSsEwWd5Joy9T9ekElhY6+NLp3DX/stC6hqcdr2NXF178XeaFlZ5x91KUV1c0w==", PhoneNumberConfirmed = false, SecurityStamp = "0aac0972-c104-4481-9c91-bf52567b6f24", TwoFactorEnabled = false, UserName = "admin@gmail.com" }
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
                        new { Id = 1, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), FirstName = "Meo", LastName = "Meo", ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), UniqueId = new Guid("4ec73af3-3cc3-48dc-848f-c517caf7ea75"), UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
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
                        new { Id = 1, CategoryId = 1, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ProductDes = "Kinh điển", ProductName = "Cuốn theo chiều gió", Quantity = 5, UniqueId = new Guid("9682743c-c2cf-4e9f-98f3-793b198a0ec9"), UnitPrice = 50.0 },
                        new { Id = 2, CategoryId = 1, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ProductDes = "Việt Nam", ProductName = "Mắt biếc", Quantity = 12, UniqueId = new Guid("53f6a96e-ca64-448a-8fca-01978f71f77a"), UnitPrice = 60.0 },
                        new { Id = 3, CategoryId = 2, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ProductDes = "Việt Nam", ProductName = "Sơ mi", Quantity = 11, UniqueId = new Guid("987caef1-e4fe-4bb0-9361-8e6a97f312d9"), UnitPrice = 60.0 },
                        new { Id = 4, CategoryId = 2, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ProductDes = "Việt Nam", ProductName = "Đầm", Quantity = 22, UniqueId = new Guid("0926a2e2-6d49-40b4-8919-1cca6d2ccd54"), UnitPrice = 70.0 }
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
                        new { Id = 1, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ProductId = 1, ProductImage = "i1.jpg", UniqueId = new Guid("e8305049-b32d-4923-b455-b7963a20a2ac") },
                        new { Id = 2, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ProductId = 2, ProductImage = "i10.jpg", UniqueId = new Guid("b57eb9f3-c6f5-4349-9323-8b351c367e03") },
                        new { Id = 3, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ProductId = 3, ProductImage = "i12.jpg", UniqueId = new Guid("d57c0cd8-67b0-46ff-a797-6859d22d1420") },
                        new { Id = 4, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), ProductId = 4, ProductImage = "i11.jpg", UniqueId = new Guid("3f3eaa2a-8b39-4844-9214-3308329d9a1a") }
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
                        new { Id = 1, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), SaleId = 1, ShipToName = "Ichi", ShipToPhone = "0888888888", UniqueId = new Guid("49213234-0a7d-4623-854f-7879d8d0e84f") },
                        new { Id = 2, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), SaleId = 2, ShipToName = "Gau Gau", ShipToPhone = "094464467", UniqueId = new Guid("aa960296-e500-4483-ae13-7833723bf8f8") }
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
                        new { Id = 1, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), OrderDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), ShipperId = 1, TotalPrice = 50.0, UniqueId = new Guid("fc84649e-80b7-42b7-8114-865b8d09473c"), UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                        new { Id = 2, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), OrderDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), ShipperId = 1, TotalPrice = 120.0, UniqueId = new Guid("54b44810-f2a0-41a8-a3b3-15f6164f4001"), UserId = "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
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
                        new { Id = 1, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), ProductId = 1, Quantity = 1, SaleOrderId = 1, UniqueId = new Guid("63e59065-585a-48c6-adc8-f2447b1f9ccd"), UnitPrice = 50.0 },
                        new { Id = 2, CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), ProductId = 3, Quantity = 2, SaleOrderId = 2, UniqueId = new Guid("2d9e51a3-3721-4a3a-8079-65013872893e"), UnitPrice = 60.0 }
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
                        new { Id = 1, ContactName = "Anga", ContactPhone = "094123321", CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), UniqueId = new Guid("58bde419-cef2-4212-b9f8-4859444501c9") },
                        new { Id = 2, ContactName = "Husky", ContactPhone = "037864457", CreatedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), ModifiedDate = new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), UniqueId = new Guid("06aba560-81c1-4504-88d4-3707952b6369") }
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
