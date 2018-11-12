using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComiShop.Migrations
{
    public partial class SetIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(maxLength: 20, nullable: true),
                    CategoryDes = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonInfo",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 15, nullable: true),
                    LastName = table.Column<string>(maxLength: 15, nullable: true),
                    Gender = table.Column<string>(maxLength: 5, nullable: true),
                    Birthday = table.Column<DateTime>(type: "date", nullable: true),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    Street = table.Column<string>(maxLength: 50, nullable: true),
                    District = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveProduct",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SaleId = table.Column<int>(nullable: false),
                    ShipToName = table.Column<string>(maxLength: 30, nullable: true),
                    ShipToPhone = table.Column<string>(maxLength: 18, nullable: true),
                    ShipToAddress = table.Column<string>(maxLength: 50, nullable: true),
                    ShipToStreet = table.Column<string>(maxLength: 50, nullable: true),
                    ShipToDistrict = table.Column<string>(maxLength: 50, nullable: true),
                    ShipToCity = table.Column<string>(maxLength: 50, nullable: true),
                    ShipToCountry = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipper",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Company = table.Column<string>(maxLength: 20, nullable: true),
                    ContactName = table.Column<string>(maxLength: 20, nullable: true),
                    ContactPhone = table.Column<string>(maxLength: 18, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipper", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(maxLength: 50, nullable: true),
                    ProductDes = table.Column<string>(maxLength: 50, nullable: true),
                    DesDetail = table.Column<string>(maxLength: 50, nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: true),
                    UnitPrice = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    CustomerType = table.Column<int>(maxLength: 10, nullable: false),
                    BankAccount = table.Column<string>(maxLength: 20, nullable: true),
                    PersonInfoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_PersonInfo_PersonInfoId",
                        column: x => x.PersonInfoId,
                        principalTable: "PersonInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetail",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    ProductImage = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    Context = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrder",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    OrderStatus = table.Column<string>(maxLength: 20, nullable: true),
                    TotalPrice = table.Column<double>(nullable: true),
                    ShippedDate = table.Column<DateTime>(type: "date", nullable: true),
                    ShipperId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    ReceiveProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleOrder_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleOrder_ReceiveProduct_ReceiveProductId",
                        column: x => x.ReceiveProductId,
                        principalTable: "ReceiveProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleOrder_Shipper_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Shipper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrderDetail",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SaleOrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: true),
                    UnitPrice = table.Column<double>(nullable: true),
                    Discount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleOrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleOrderDetail_SaleOrder_SaleOrderId",
                        column: x => x.SaleOrderId,
                        principalTable: "SaleOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Description", "Name", "NormalizedName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "12536547-4dc6-465b-bd46-ce8ab5bb8647", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BankAccount", "ConcurrencyStamp", "CustomerType", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonInfoId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, null, "c2819bab-a461-4df3-b57a-def6743da8f9", 0, "admin@gmail.com", false, true, null, "admin@gmail.com", "admin@gmail.com", "AQAAAAEAACcQAAAAELcSBYWaPyfsfjyblKANOEqM7o5b8CajIurfLpEmm1deAeDpO4xHDplXaDlGylUnOg==", null, null, false, "a6d45a94-8a51-4e74-a0e1-2b9275e1c402", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryDes", "CategoryName", "CreatedDate", "Deleted", "ModifiedDate", "UniqueId" },
                values: new object[,]
                {
                    { 1, "Tiểu thuyết nổi tiếng", "Sách", new DateTime(2018, 11, 14, 19, 3, 13, 759, DateTimeKind.Local), null, new DateTime(2018, 11, 14, 19, 3, 13, 759, DateTimeKind.Local), new Guid("c1f2f2e2-3cd1-4a97-bbe0-556a9b064cb4") },
                    { 2, "Quần áo", "Quần áo", new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), null, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), new Guid("a98c8a48-fefa-4a83-8d7b-10b69079f736") }
                });

            migrationBuilder.InsertData(
                table: "PersonInfo",
                columns: new[] { "Id", "Address", "Birthday", "City", "Country", "CreatedDate", "Deleted", "District", "FirstName", "Gender", "LastName", "ModifiedDate", "Street", "UniqueId", "UserId" },
                values: new object[] { 1, null, null, null, null, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), null, null, "Meo", null, "Meo", new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), null, new Guid("e91ff8a9-81a6-489d-87f9-b04cfbb5f26e"), "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.InsertData(
                table: "ReceiveProduct",
                columns: new[] { "Id", "CreatedDate", "Deleted", "ModifiedDate", "SaleId", "ShipToAddress", "ShipToCity", "ShipToCountry", "ShipToDistrict", "ShipToName", "ShipToPhone", "ShipToStreet", "UniqueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), null, new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), 1, null, null, null, null, "Ichi", "0888888888", null, new Guid("61a8c7c4-b922-42de-bf99-542b25c10717") },
                    { 2, new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), null, new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), 2, null, null, null, null, "Gau Gau", "094464467", null, new Guid("624433cd-c21e-4ac6-b00f-0a9111837585") }
                });

            migrationBuilder.InsertData(
                table: "Shipper",
                columns: new[] { "Id", "Company", "ContactName", "ContactPhone", "CreatedDate", "Deleted", "ModifiedDate", "UniqueId" },
                values: new object[,]
                {
                    { 1, null, "Anga", "094123321", new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), null, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), new Guid("1b95c2c0-02c7-4659-b21f-d3dc5248f5da") },
                    { 2, null, "Husky", "037864457", new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), null, new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), new Guid("ddf0c24e-fae9-4abe-8263-ff0138939ccc") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Deleted", "DesDetail", "ModifiedDate", "ProductDes", "ProductName", "Quantity", "UniqueId", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), null, null, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), "Kinh điển", "Cuốn theo chiều gió", 5, new Guid("43731edb-984a-4b5d-bc42-f85364654464"), 50.0 },
                    { 2, 1, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), null, null, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), "Việt Nam", "Mắt biếc", 12, new Guid("58c71da6-a9dc-4d88-9314-09fbdc91222f"), 60.0 },
                    { 3, 2, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), null, null, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), "Việt Nam", "Sơ mi", 11, new Guid("58cb18ea-bdb0-4bf1-879f-199c0aac51a0"), 60.0 },
                    { 4, 2, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), null, null, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), "Việt Nam", "Đầm", 22, new Guid("ca4f8a87-ec35-4c41-ae0f-679ccaf610cc"), 70.0 }
                });

            migrationBuilder.InsertData(
                table: "SaleOrder",
                columns: new[] { "Id", "ApplicationUserId", "CreatedDate", "Deleted", "ModifiedDate", "OrderStatus", "ReceiveProductId", "ShippedDate", "ShipperId", "TotalPrice", "UniqueId", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), null, new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), null, null, null, 1, 50.0, new Guid("cdeedf70-db7e-490e-a078-94b6e7a8063f"), "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { 2, null, new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), null, new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), null, null, null, 1, 120.0, new Guid("1b58d27c-289c-4eb9-addd-fe266e1342e7"), "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ProductDetail",
                columns: new[] { "Id", "CreatedDate", "Deleted", "ModifiedDate", "ProductId", "ProductImage", "UniqueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), null, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), 1, "i1.jpg", new Guid("24623e17-9ab6-4d0f-b905-5d79debbe306") },
                    { 2, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), null, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), 2, "i10.jpg", new Guid("2f1bb8be-db28-44bb-b766-8105e09c92ca") },
                    { 3, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), null, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), 3, "i12.jpg", new Guid("8d993c1e-0786-4bc3-b367-31f58efa3b8c") },
                    { 4, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), null, new DateTime(2018, 11, 14, 19, 3, 13, 760, DateTimeKind.Local), 4, "i11.jpg", new Guid("282aff3d-1dab-4a8b-ae78-60610f2ee5d4") }
                });

            migrationBuilder.InsertData(
                table: "SaleOrderDetail",
                columns: new[] { "Id", "CreatedDate", "Deleted", "Discount", "ModifiedDate", "ProductId", "Quantity", "SaleOrderId", "UniqueId", "UnitPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), null, null, new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), 1, 1, 1, new Guid("66e17bf2-dd00-4267-bafa-65ec6de1cbad"), 50.0 },
                    { 2, new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), null, null, new DateTime(2018, 11, 14, 19, 3, 13, 761, DateTimeKind.Local), 3, 2, 2, new Guid("b1fd3d34-8b21-4945-82cd-321db9debd5c"), 60.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonInfoId",
                table: "AspNetUsers",
                column: "PersonInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ApplicationUserId",
                table: "Comment",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ProductId",
                table: "Comment",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_ProductId",
                table: "ProductDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_ApplicationUserId",
                table: "SaleOrder",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_ReceiveProductId",
                table: "SaleOrder",
                column: "ReceiveProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_ShipperId",
                table: "SaleOrder",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetail_ProductId",
                table: "SaleOrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetail_SaleOrderId",
                table: "SaleOrderDetail",
                column: "SaleOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "ProductDetail");

            migrationBuilder.DropTable(
                name: "SaleOrderDetail");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SaleOrder");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ReceiveProduct");

            migrationBuilder.DropTable(
                name: "Shipper");

            migrationBuilder.DropTable(
                name: "PersonInfo");
        }
    }
}
