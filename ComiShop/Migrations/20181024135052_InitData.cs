using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComiShop.Migrations
{
    public partial class InitData : Migration
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
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Timestamp = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    CategoryId = table.Column<string>(maxLength: 7, nullable: false),
                    CategoryName = table.Column<string>(maxLength: 20, nullable: true),
                    CategoryDes = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Timestamp = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    CustomerId = table.Column<string>(maxLength: 7, nullable: false),
                    CustomerType = table.Column<int>(maxLength: 10, nullable: false),
                    BankAccount = table.Column<string>(maxLength: 20, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Shipper",
                columns: table => new
                {
                    Timestamp = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    ShipperId = table.Column<string>(maxLength: 7, nullable: false),
                    Company = table.Column<string>(maxLength: 20, nullable: true),
                    ContactName = table.Column<string>(maxLength: 20, nullable: true),
                    ContactPhone = table.Column<string>(maxLength: 18, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipper", x => x.ShipperId);
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
                name: "Product",
                columns: table => new
                {
                    Timestamp = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    ProductId = table.Column<string>(maxLength: 7, nullable: false),
                    ProductName = table.Column<string>(maxLength: 50, nullable: true),
                    ProductDes = table.Column<string>(maxLength: 50, nullable: true),
                    CategoryId = table.Column<string>(maxLength: 7, nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonInfo",
                columns: table => new
                {
                    Timestamp = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    CustomerId = table.Column<string>(maxLength: 7, nullable: false),
                    FirstName = table.Column<string>(maxLength: 15, nullable: true),
                    LastName = table.Column<string>(maxLength: 15, nullable: true),
                    Gender = table.Column<string>(maxLength: 5, nullable: true),
                    Birthday = table.Column<DateTime>(type: "date", nullable: true),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    Street = table.Column<string>(maxLength: 50, nullable: true),
                    District = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Phone = table.Column<string>(maxLength: 18, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonInfo", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_PersonInfo_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrder",
                columns: table => new
                {
                    Timestamp = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    SaleOrderId = table.Column<string>(maxLength: 7, nullable: false),
                    CustomerId = table.Column<string>(maxLength: 7, nullable: true),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: true),
                    OrderStatus = table.Column<string>(maxLength: 20, nullable: true),
                    TotalPrice = table.Column<double>(nullable: true),
                    ShippedDate = table.Column<DateTime>(type: "date", nullable: true),
                    ShipperId = table.Column<string>(maxLength: 7, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrder", x => x.SaleOrderId);
                    table.ForeignKey(
                        name: "FK_SaleOrder_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleOrder_Shipper_ShipperId",
                        column: x => x.ShipperId,
                        principalTable: "Shipper",
                        principalColumn: "ShipperId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetail",
                columns: table => new
                {
                    Timestamp = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    ProductId = table.Column<string>(maxLength: 7, nullable: false),
                    DesDetail = table.Column<string>(maxLength: 50, nullable: true),
                    ProductImage = table.Column<string>(maxLength: 50, nullable: true),
                    Comment = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetail", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveProduct",
                columns: table => new
                {
                    Timestamp = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    SaleOrderId = table.Column<string>(maxLength: 7, nullable: false),
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
                    table.PrimaryKey("PK_ReceiveProduct", x => x.SaleOrderId);
                    table.ForeignKey(
                        name: "FK_ReceiveProduct_SaleOrder_SaleOrderId",
                        column: x => x.SaleOrderId,
                        principalTable: "SaleOrder",
                        principalColumn: "SaleOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrderDetail",
                columns: table => new
                {
                    Timestamp = table.Column<byte[]>(nullable: true),
                    Deleted = table.Column<bool>(nullable: true),
                    SaleOrderDetailId = table.Column<string>(maxLength: 7, nullable: false),
                    SaleOrderId = table.Column<string>(maxLength: 7, nullable: true),
                    ProductId = table.Column<string>(maxLength: 7, nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    UnitPrice = table.Column<double>(nullable: true),
                    Discount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrderDetail", x => x.SaleOrderDetailId);
                    table.ForeignKey(
                        name: "FK_SaleOrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleOrderDetail_SaleOrder_SaleOrderId",
                        column: x => x.SaleOrderId,
                        principalTable: "SaleOrder",
                        principalColumn: "SaleOrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Description", "Name", "NormalizedName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "687c8e66-b56f-4b9f-937c-5d21f8525fbe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "fe4aa8b3-a81a-48db-861b-e935c00d2dc7", "admin@gmail.com", false, null, null, true, null, "admin@gmail.com", "admin@gmail.com", "AQAAAAEAACcQAAAAEIqBPODFmwEphoxsA0p98pFxYel0/SuXx9TnQA4FX77vA7ITxM3xiYePLhmaFygM2w==", null, false, "6981f064-cb8b-437e-b26b-e492fe713538", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryDes", "CategoryName", "CreateDate", "Deleted", "LastUpdate", "Timestamp" },
                values: new object[,]
                {
                    { "C001", "Tiểu thuyết nổi tiếng", "Tiểu thuyết", null, null, null, null },
                    { "C002", "Tuyển tập truyện ngắn", "Truyện ngắn", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "BankAccount", "CreateDate", "CustomerType", "Deleted", "LastUpdate", "Timestamp" },
                values: new object[,]
                {
                    { "Cust001", null, null, 0, null, null, null },
                    { "Cust002", null, null, 2, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Shipper",
                columns: new[] { "ShipperId", "Company", "ContactName", "ContactPhone", "CreateDate", "Deleted", "LastUpdate", "Timestamp" },
                values: new object[,]
                {
                    { "SP001", null, "Anga", "094123321", null, null, null, null },
                    { "SP002", null, "Husky", "037864457", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.InsertData(
                table: "PersonInfo",
                columns: new[] { "CustomerId", "Address", "Birthday", "City", "Country", "Deleted", "District", "Email", "FirstName", "Gender", "LastName", "Phone", "Street", "Timestamp" },
                values: new object[,]
                {
                    { "Cust001", null, null, null, null, null, null, "meomeo@gmail.com", "Meo", null, "Meo", "0354464467", null, null },
                    { "Cust002", null, null, null, null, null, null, "gaugau@gmail.com", "Gau", null, "Gau", "094464467", null, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "CreateDate", "Deleted", "LastUpdate", "ProductDes", "ProductName", "Quantity", "Timestamp" },
                values: new object[,]
                {
                    { "P001", "C001", null, null, null, "Kinh điển", "Cuốn theo chiều gió", 5, null },
                    { "P002", "C002", null, null, null, "Việt Nam", "Mắt biếc", 12, null }
                });

            migrationBuilder.InsertData(
                table: "SaleOrder",
                columns: new[] { "SaleOrderId", "CreateDate", "CustomerId", "Deleted", "LastUpdate", "OrderDate", "OrderStatus", "ShippedDate", "ShipperId", "Timestamp", "TotalPrice" },
                values: new object[,]
                {
                    { "SO001", null, "Cust001", null, null, new DateTime(2018, 10, 24, 20, 50, 52, 345, DateTimeKind.Local), null, null, null, null, 150000.0 },
                    { "SO002", null, "Cust002", null, null, new DateTime(2018, 10, 24, 20, 50, 52, 346, DateTimeKind.Local), null, null, null, null, 500000.0 }
                });

            migrationBuilder.InsertData(
                table: "ReceiveProduct",
                columns: new[] { "SaleOrderId", "Deleted", "ShipToAddress", "ShipToCity", "ShipToCountry", "ShipToDistrict", "ShipToName", "ShipToPhone", "ShipToStreet", "Timestamp" },
                values: new object[,]
                {
                    { "SO001", null, null, null, null, null, "Ichi", "0888888888", null, null },
                    { "SO002", null, null, null, null, null, "Gau Gau", "094464467", null, null }
                });

            migrationBuilder.InsertData(
                table: "SaleOrderDetail",
                columns: new[] { "SaleOrderDetailId", "Deleted", "Discount", "ProductId", "Quantity", "SaleOrderId", "Timestamp", "UnitPrice" },
                values: new object[,]
                {
                    { "SOD001", null, null, "P001", 1, "SO001", null, 150000.0 },
                    { "SOD002", null, null, "P002", 2, "SO002", null, 250000.0 }
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
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_CustomerId",
                table: "SaleOrder",
                column: "CustomerId");

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
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SaleOrder");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Shipper");
        }
    }
}
