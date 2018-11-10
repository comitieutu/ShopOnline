using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComiShop.Migrations
{
    public partial class FixDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonInfo_Customer_CustomerId",
                table: "PersonInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetail_Product_ProductId",
                table: "ProductDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceiveProduct_SaleOrder_SaleOrderId",
                table: "ReceiveProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_Customer_CustomerId",
                table: "SaleOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_Shipper_ShipperId",
                table: "SaleOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrderDetail_Product_ProductId",
                table: "SaleOrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrderDetail_SaleOrder_SaleOrderId",
                table: "SaleOrderDetail");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shipper",
                table: "Shipper");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleOrderDetail",
                table: "SaleOrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleOrder",
                table: "SaleOrder");

            migrationBuilder.DropIndex(
                name: "IX_SaleOrder_CustomerId",
                table: "SaleOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReceiveProduct",
                table: "ReceiveProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductDetail",
                table: "ProductDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonInfo",
                table: "PersonInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DeleteData(
                table: "PersonInfo",
                keyColumn: "CustomerId",
                keyValue: "Cust001");

            migrationBuilder.DeleteData(
                table: "PersonInfo",
                keyColumn: "CustomerId",
                keyValue: "Cust002");

            migrationBuilder.DeleteData(
                table: "ReceiveProduct",
                keyColumn: "SaleOrderId",
                keyValue: "SO001");

            migrationBuilder.DeleteData(
                table: "ReceiveProduct",
                keyColumn: "SaleOrderId",
                keyValue: "SO002");

            migrationBuilder.DeleteData(
                table: "SaleOrderDetail",
                keyColumn: "SaleOrderDetailId",
                keyValue: "SOD001");

            migrationBuilder.DeleteData(
                table: "SaleOrderDetail",
                keyColumn: "SaleOrderDetailId",
                keyValue: "SOD002");

            migrationBuilder.DeleteData(
                table: "Shipper",
                keyColumn: "ShipperId",
                keyValue: "SP001");

            migrationBuilder.DeleteData(
                table: "Shipper",
                keyColumn: "ShipperId",
                keyValue: "SP002");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: "P001");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: "P002");

            migrationBuilder.DeleteData(
                table: "SaleOrder",
                keyColumn: "SaleOrderId",
                keyValue: "SO001");

            migrationBuilder.DeleteData(
                table: "SaleOrder",
                keyColumn: "SaleOrderId",
                keyValue: "SO002");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: "C001");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: "C002");

            migrationBuilder.DropColumn(
                name: "ShipperId",
                table: "Shipper");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Shipper");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Shipper");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Shipper");

            migrationBuilder.DropColumn(
                name: "SaleOrderDetailId",
                table: "SaleOrderDetail");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "SaleOrderDetail");

            migrationBuilder.DropColumn(
                name: "SaleOrderId",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "SaleOrderId",
                table: "ReceiveProduct");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "ReceiveProduct");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "DesDetail",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "PersonInfo");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "PersonInfo");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "PersonInfo");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "PersonInfo");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Shipper",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Shipper",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Shipper",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueId",
                table: "Shipper",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "SaleOrderId",
                table: "SaleOrderDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "SaleOrderDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SaleOrderDetail",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SaleOrderDetail",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "SaleOrderDetail",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueId",
                table: "SaleOrderDetail",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "ShipperId",
                table: "SaleOrder",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SaleOrder",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "SaleOrder",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SaleOrder",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "SaleOrder",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ReceiveProductId",
                table: "SaleOrder",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueId",
                table: "SaleOrder",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "SaleOrder",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ReceiveProduct",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ReceiveProduct",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ReceiveProduct",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "ReceiveProduct",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueId",
                table: "ReceiveProduct",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 7);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductDetail",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ProductDetail",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ProductDetail",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueId",
                table: "ProductDetail",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 7,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Product",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Product",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DesDetail",
                table: "Product",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Product",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueId",
                table: "Product",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<double>(
                name: "UnitPrice",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PersonInfo",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PersonInfo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PersonInfo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueId",
                table: "PersonInfo",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PersonInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Category",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueId",
                table: "Category",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "BankAccount",
                table: "AspNetUsers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerType",
                table: "AspNetUsers",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonInfoId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shipper",
                table: "Shipper",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleOrderDetail",
                table: "SaleOrderDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleOrder",
                table: "SaleOrder",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReceiveProduct",
                table: "ReceiveProduct",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductDetail",
                table: "ProductDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonInfo",
                table: "PersonInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "8447b005-221d-4755-9ec0-3599fc5efe5d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00e53f3b-4b73-4469-8c18-5348dd96df06", "AQAAAAEAACcQAAAAEI8ZjVr5k0rSvi5vPVSwg1Qes5/HGSO06WvZ5WJP1XT8nvtRWaK6MwEXjL+7t8eNTQ==", "52f05ef3-5613-4f98-bdb4-f3c343141e08" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryDes", "CategoryName", "CreatedDate", "Deleted", "ModifiedDate", "UniqueId" },
                values: new object[,]
                {
                    { 1, "Tiểu thuyết nổi tiếng", "Sách", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cb966ed6-29b6-4bfc-ae6c-c583d792e528") },
                    { 2, "Quần áo", "Quần áo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2fd64a9-f8f4-4b05-a27c-cc465fd46a58") }
                });

            migrationBuilder.InsertData(
                table: "PersonInfo",
                columns: new[] { "Id", "Address", "Birthday", "City", "Country", "CreatedDate", "Deleted", "District", "FirstName", "Gender", "LastName", "ModifiedDate", "Street", "UniqueId", "UserId" },
                values: new object[] { 1, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Meo", null, "Meo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("43d59a79-0930-49c9-a903-42a8ae580631"), "a18be9c0-aa65-4af8-bd17-00bd9344e575" });

            migrationBuilder.InsertData(
                table: "ReceiveProduct",
                columns: new[] { "Id", "CreatedDate", "Deleted", "ModifiedDate", "SaleId", "ShipToAddress", "ShipToCity", "ShipToCountry", "ShipToDistrict", "ShipToName", "ShipToPhone", "ShipToStreet", "UniqueId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, null, null, "Ichi", "0888888888", null, new Guid("45a2980e-7e1c-498c-8f0a-6597eda54dd0") },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, null, null, "Gau Gau", "094464467", null, new Guid("c3f020c4-8cf6-4fe2-993a-5523f55bc4f5") }
                });

            migrationBuilder.InsertData(
                table: "Shipper",
                columns: new[] { "Id", "Company", "ContactName", "ContactPhone", "CreatedDate", "Deleted", "ModifiedDate", "UniqueId" },
                values: new object[,]
                {
                    { 1, null, "Anga", "094123321", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1b54aeed-4e86-4b28-a629-ffebbe288dca") },
                    { 2, null, "Husky", "037864457", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a1853a48-7ae0-45a3-abf1-bac47b171a8b") }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Deleted", "DesDetail", "ModifiedDate", "ProductDes", "ProductName", "Quantity", "UniqueId", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kinh điển", "Cuốn theo chiều gió", 5, new Guid("3328cb12-e85f-494a-a571-992765837498"), 50.0 },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Việt Nam", "Mắt biếc", 12, new Guid("9a1bb2e7-5d4d-42cf-bb62-4db20b612072"), 60.0 },
                    { 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Việt Nam", "Sơ mi", 11, new Guid("14cb7140-d284-49ff-994f-acea95cadac4"), 60.0 },
                    { 4, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Việt Nam", "Đầm", 22, new Guid("8b51d174-cd30-4677-93a4-c74a35f64ca3"), 70.0 }
                });

            migrationBuilder.InsertData(
                table: "SaleOrder",
                columns: new[] { "Id", "ApplicationUserId", "CreatedDate", "Deleted", "ModifiedDate", "OrderDate", "OrderStatus", "ReceiveProductId", "ShippedDate", "ShipperId", "TotalPrice", "UniqueId", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 10, 21, 19, 38, 306, DateTimeKind.Local), null, null, null, 1, 50.0, new Guid("d5229d71-6e5d-4d91-8729-71046b34b239"), "a18be9c0-aa65-4af8-bd17-00bd9344e575" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 10, 21, 19, 38, 307, DateTimeKind.Local), null, null, null, 1, 120.0, new Guid("d40567d7-86b9-422d-96bd-f95dd88beed7"), "a18be9c0-aa65-4af8-bd17-00bd9344e575" }
                });

            migrationBuilder.InsertData(
                table: "ProductDetail",
                columns: new[] { "Id", "CreatedDate", "Deleted", "ModifiedDate", "ProductId", "ProductImage", "UniqueId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "i1.jpg", new Guid("2760cf56-cbe1-4452-bfc5-58a1211cff2c") },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "i10.jpg", new Guid("aa17caa3-6b4c-44a5-916c-256a5740dbea") },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "i12.jpg", new Guid("6e8d0cab-88c4-4b1c-ab7c-8bf5a6127fb5") },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "i11.jpg", new Guid("9d23f0cd-4328-4b28-964e-f3231fca9c9c") }
                });

            migrationBuilder.InsertData(
                table: "SaleOrderDetail",
                columns: new[] { "Id", "CreatedDate", "Deleted", "Discount", "ModifiedDate", "ProductId", "Quantity", "SaleOrderId", "UniqueId", "UnitPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, new Guid("6a2408f3-111a-47f4-adbe-8351ed385cd9"), 50.0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, 2, new Guid("c65389e1-426e-4ed7-a4f6-69780295b645"), 60.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_ApplicationUserId",
                table: "SaleOrder",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_ReceiveProductId",
                table: "SaleOrder",
                column: "ReceiveProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_ProductId",
                table: "ProductDetail",
                column: "ProductId",
                unique: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PersonInfo_PersonInfoId",
                table: "AspNetUsers",
                column: "PersonInfoId",
                principalTable: "PersonInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetail_Product_ProductId",
                table: "ProductDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_AspNetUsers_ApplicationUserId",
                table: "SaleOrder",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_ReceiveProduct_ReceiveProductId",
                table: "SaleOrder",
                column: "ReceiveProductId",
                principalTable: "ReceiveProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_Shipper_ShipperId",
                table: "SaleOrder",
                column: "ShipperId",
                principalTable: "Shipper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrderDetail_Product_ProductId",
                table: "SaleOrderDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrderDetail_SaleOrder_SaleOrderId",
                table: "SaleOrderDetail",
                column: "SaleOrderId",
                principalTable: "SaleOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PersonInfo_PersonInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetail_Product_ProductId",
                table: "ProductDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_AspNetUsers_ApplicationUserId",
                table: "SaleOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_ReceiveProduct_ReceiveProductId",
                table: "SaleOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_Shipper_ShipperId",
                table: "SaleOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrderDetail_Product_ProductId",
                table: "SaleOrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrderDetail_SaleOrder_SaleOrderId",
                table: "SaleOrderDetail");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shipper",
                table: "Shipper");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleOrderDetail",
                table: "SaleOrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleOrder",
                table: "SaleOrder");

            migrationBuilder.DropIndex(
                name: "IX_SaleOrder_ApplicationUserId",
                table: "SaleOrder");

            migrationBuilder.DropIndex(
                name: "IX_SaleOrder_ReceiveProductId",
                table: "SaleOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReceiveProduct",
                table: "ReceiveProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductDetail",
                table: "ProductDetail");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetail_ProductId",
                table: "ProductDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonInfo",
                table: "PersonInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonInfoId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "PersonInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReceiveProduct",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReceiveProduct",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SaleOrderDetail",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SaleOrderDetail",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shipper",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SaleOrder",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SaleOrder",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shipper",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Shipper");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Shipper");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Shipper");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Shipper");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SaleOrderDetail");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SaleOrderDetail");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "SaleOrderDetail");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "SaleOrderDetail");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "ReceiveProductId",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ReceiveProduct");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ReceiveProduct");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ReceiveProduct");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "ReceiveProduct");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "ReceiveProduct");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DesDetail",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonInfo");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PersonInfo");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PersonInfo");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "PersonInfo");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PersonInfo");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "BankAccount",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomerType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonInfoId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ShipperId",
                table: "Shipper",
                maxLength: 7,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Shipper",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "Shipper",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Shipper",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SaleOrderId",
                table: "SaleOrderDetail",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "SaleOrderDetail",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "SaleOrderDetailId",
                table: "SaleOrderDetail",
                maxLength: 7,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "SaleOrderDetail",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShipperId",
                table: "SaleOrder",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "SaleOrderId",
                table: "SaleOrder",
                maxLength: 7,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "SaleOrder",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "SaleOrder",
                maxLength: 7,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "SaleOrder",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "SaleOrder",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaleOrderId",
                table: "ReceiveProduct",
                maxLength: 7,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "ReceiveProduct",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "ProductDetail",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "ProductDetail",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DesDetail",
                table: "ProductDetail",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "ProductDetail",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Product",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "Product",
                maxLength: 7,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Product",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "Product",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "PersonInfo",
                maxLength: 7,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PersonInfo",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "PersonInfo",
                maxLength: 18,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "PersonInfo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "Category",
                maxLength: 7,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "Category",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Category",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shipper",
                table: "Shipper",
                column: "ShipperId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleOrderDetail",
                table: "SaleOrderDetail",
                column: "SaleOrderDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleOrder",
                table: "SaleOrder",
                column: "SaleOrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReceiveProduct",
                table: "ReceiveProduct",
                column: "SaleOrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductDetail",
                table: "ProductDetail",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonInfo",
                table: "PersonInfo",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<string>(maxLength: 7, nullable: false),
                    BankAccount = table.Column<string>(maxLength: 20, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    CustomerType = table.Column<int>(maxLength: 10, nullable: false),
                    Deleted = table.Column<bool>(nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "date", nullable: true),
                    Timestamp = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "687c8e66-b56f-4b9f-937c-5d21f8525fbe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe4aa8b3-a81a-48db-861b-e935c00d2dc7", "AQAAAAEAACcQAAAAEIqBPODFmwEphoxsA0p98pFxYel0/SuXx9TnQA4FX77vA7ITxM3xiYePLhmaFygM2w==", "6981f064-cb8b-437e-b26b-e492fe713538" });

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
                name: "IX_SaleOrder_CustomerId",
                table: "SaleOrder",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonInfo_Customer_CustomerId",
                table: "PersonInfo",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetail_Product_ProductId",
                table: "ProductDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiveProduct_SaleOrder_SaleOrderId",
                table: "ReceiveProduct",
                column: "SaleOrderId",
                principalTable: "SaleOrder",
                principalColumn: "SaleOrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_Customer_CustomerId",
                table: "SaleOrder",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_Shipper_ShipperId",
                table: "SaleOrder",
                column: "ShipperId",
                principalTable: "Shipper",
                principalColumn: "ShipperId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrderDetail_Product_ProductId",
                table: "SaleOrderDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrderDetail_SaleOrder_SaleOrderId",
                table: "SaleOrderDetail",
                column: "SaleOrderId",
                principalTable: "SaleOrder",
                principalColumn: "SaleOrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
