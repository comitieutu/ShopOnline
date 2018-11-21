using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComiShop.Migrations
{
    public partial class InitLast : Migration
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
                    BankAccount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipper",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Company = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    ContactPhone = table.Column<string>(nullable: true)
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
                name: "PersonInfo",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonInfo_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDes = table.Column<string>(nullable: true),
                    DesDetail = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<double>(nullable: false)
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
                name: "SaleOrder",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    OrderStatus = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<double>(nullable: false),
                    ShippedDate = table.Column<DateTime>(type: "date", nullable: true),
                    Payment = table.Column<bool>(nullable: false),
                    ShipperId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
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
                        name: "FK_SaleOrder_Shipper_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Shipper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
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
                name: "ProductDetail",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    ProductImage = table.Column<string>(nullable: true)
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
                name: "ReceiveProduct",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SaleId = table.Column<int>(nullable: false),
                    ShipToName = table.Column<string>(nullable: true),
                    ShipToPhone = table.Column<string>(nullable: true),
                    ShipToAddress = table.Column<string>(nullable: true),
                    ShipToStreet = table.Column<string>(nullable: true),
                    ShipToDistrict = table.Column<string>(nullable: true),
                    ShipToCity = table.Column<string>(nullable: true),
                    ShipToCountry = table.Column<string>(nullable: true),
                    SaleOrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiveProduct_SaleOrder_SaleOrderId",
                        column: x => x.SaleOrderId,
                        principalTable: "SaleOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrderDetail",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SaleOrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<double>(nullable: false),
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
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "9285ad9b-c601-42d9-8b60-9fbe98578312", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BankAccount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, null, "3530985d-dcfd-4e1f-ae6b-cca48cbd5281", "admin@gmail.com", false, true, null, "admin@gmail.com", "admin@gmail.com", "AQAAAAEAACcQAAAAEB9VxTUlU8tq5U1VAIM77hFoKwOp26eGuoNKe3LTRQlOqy0C0evhlEsTvnQWMEDmjg==", null, false, "cbd59e83-a5e8-4b67-b213-40d41c9b2e56", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryDes", "CategoryName", "CreatedDate", "Deleted", "ModifiedDate", "UniqueId" },
                values: new object[,]
                {
                    { 1, "Tiểu thuyết nổi tiếng", "Sách", new DateTime(2018, 11, 21, 0, 20, 38, 706, DateTimeKind.Local), false, new DateTime(2018, 11, 21, 0, 20, 38, 706, DateTimeKind.Local), new Guid("ce4c1910-7a0b-4589-b61d-d7b814ef6743") },
                    { 2, "Quần áo", "Quần áo", new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), false, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), new Guid("f792738f-e27e-4683-b69b-eec62620d5a8") }
                });

            migrationBuilder.InsertData(
                table: "ReceiveProduct",
                columns: new[] { "Id", "CreatedDate", "Deleted", "ModifiedDate", "SaleId", "SaleOrderId", "ShipToAddress", "ShipToCity", "ShipToCountry", "ShipToDistrict", "ShipToName", "ShipToPhone", "ShipToStreet", "UniqueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), false, new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), 1, null, null, null, null, null, "Ichi", "0888888888", null, new Guid("422bde86-10a8-40f2-9d65-164c2278ce24") },
                    { 2, new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), false, new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), 2, null, null, null, null, null, "Gau Gau", "094464467", null, new Guid("31b51513-25dc-4bcb-a175-43cd1f088c98") }
                });

            migrationBuilder.InsertData(
                table: "Shipper",
                columns: new[] { "Id", "Company", "ContactName", "ContactPhone", "CreatedDate", "Deleted", "ModifiedDate", "UniqueId" },
                values: new object[,]
                {
                    { 1, null, "Anga", "094123321", new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), false, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), new Guid("5610bcf9-4b14-4b3e-9468-f06674e5b84c") },
                    { 2, null, "Husky", "037864457", new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), false, new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), new Guid("a2a91757-7b17-4513-892b-d3aa57035506") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.InsertData(
                table: "PersonInfo",
                columns: new[] { "Id", "Address", "Birthday", "City", "Country", "CreatedDate", "Deleted", "District", "FirstName", "Gender", "LastName", "ModifiedDate", "Street", "UniqueId", "UserId" },
                values: new object[] { 1, null, null, null, null, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), false, null, "Meo", null, "Meo", new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), null, new Guid("bc0cbf09-9467-4f77-91a8-af27dcb523c0"), "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Deleted", "DesDetail", "ModifiedDate", "ProductDes", "ProductName", "Quantity", "UniqueId", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), false, null, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), "Kinh điển", "Cuốn theo chiều gió", 5, new Guid("9cdb117a-d99f-4b09-857c-1d883efce7c7"), 50.0 },
                    { 2, 1, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), false, null, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), "Việt Nam", "Mắt biếc", 12, new Guid("f01294a2-c27d-464a-8b3d-b93f559a7882"), 60.0 },
                    { 3, 2, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), false, null, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), "Việt Nam", "Sơ mi", 11, new Guid("4a94762b-b59c-49da-808f-f33f3b0248f6"), 60.0 },
                    { 4, 2, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), false, null, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), "Việt Nam", "Đầm", 22, new Guid("1207765f-4577-4018-849f-b84630397196"), 70.0 }
                });

            migrationBuilder.InsertData(
                table: "SaleOrder",
                columns: new[] { "Id", "ApplicationUserId", "CreatedDate", "Deleted", "ModifiedDate", "OrderStatus", "Payment", "ShippedDate", "ShipperId", "TotalPrice", "UniqueId", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), false, new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), null, false, null, 1, 50.0, new Guid("c5c1296f-3a82-4859-8cec-a11237435dd6"), "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { 2, null, new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), false, new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), null, false, null, 1, 120.0, new Guid("975a2b2f-c1dd-4445-a5e1-dba25e377c75"), "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ProductDetail",
                columns: new[] { "Id", "CreatedDate", "Deleted", "ModifiedDate", "ProductId", "ProductImage", "UniqueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), false, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), 1, "i1.jpg", new Guid("3a79927d-dd40-49eb-a355-51c896bfbec3") },
                    { 2, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), false, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), 2, "i10.jpg", new Guid("1602d9c4-5ac6-4786-ba05-da91fb6d2503") },
                    { 3, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), false, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), 3, "i12.jpg", new Guid("cfa706f3-ab9d-48fe-a88e-55403f0b3152") },
                    { 4, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), false, new DateTime(2018, 11, 21, 0, 20, 38, 707, DateTimeKind.Local), 4, "i11.jpg", new Guid("88ba774a-4ea4-4136-8970-852f9f4fff0a") }
                });

            migrationBuilder.InsertData(
                table: "SaleOrderDetail",
                columns: new[] { "Id", "CreatedDate", "Deleted", "Discount", "ModifiedDate", "ProductId", "Quantity", "SaleOrderId", "UniqueId", "UnitPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), false, null, new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), 1, 1, 1, new Guid("16929525-0834-4299-ab89-9cd792d79be4"), 50.0 },
                    { 2, new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), false, null, new DateTime(2018, 11, 21, 0, 20, 38, 708, DateTimeKind.Local), 3, 2, 2, new Guid("9fc33088-1234-4edb-a30a-1166863d07d7"), 60.0 }
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
                name: "IX_Comment_ApplicationUserId",
                table: "Comment",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ProductId",
                table: "Comment",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonInfo_UserId",
                table: "PersonInfo",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_ProductId",
                table: "ProductDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveProduct_SaleOrderId",
                table: "ReceiveProduct",
                column: "SaleOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_ApplicationUserId",
                table: "SaleOrder",
                column: "ApplicationUserId");

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
                name: "PersonInfo");

            migrationBuilder.DropTable(
                name: "ProductDetail");

            migrationBuilder.DropTable(
                name: "ReceiveProduct");

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
                name: "Shipper");
        }
    }
}
