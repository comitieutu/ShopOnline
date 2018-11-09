using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class InitDataVer1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "SO001", null, "Cust001", null, null, new DateTime(2018, 9, 30, 21, 45, 31, 134, DateTimeKind.Local), null, null, null, null, 150000.0 },
                    { "SO002", null, "Cust002", null, null, new DateTime(2018, 9, 30, 21, 45, 31, 135, DateTimeKind.Local), null, null, null, null, 500000.0 }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: "Cust001");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: "Cust002");
        }
    }
}
