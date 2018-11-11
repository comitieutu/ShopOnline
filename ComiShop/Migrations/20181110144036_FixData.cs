using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComiShop.Migrations
{
    public partial class FixData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "6db04c14-e738-45f9-bb6a-6806d7aeadc3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8d9a644-5103-459e-8092-73bc060b4420", "AQAAAAEAACcQAAAAEEWYuSsEwWd5Joy9T9ekElhY6+NLp3DX/stC6hqcdr2NXF178XeaFlZ5x91KUV1c0w==", "0aac0972-c104-4481-9c91-bf52567b6f24" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 536, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 536, DateTimeKind.Local), new Guid("0daa6bf9-d18f-43fa-b231-dee8fe5a5c33") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new Guid("59570ab9-91fb-4323-aa4e-9d57f54a1d84") });

            migrationBuilder.UpdateData(
                table: "PersonInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new Guid("4ec73af3-3cc3-48dc-848f-c517caf7ea75") });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new Guid("9682743c-c2cf-4e9f-98f3-793b198a0ec9") });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new Guid("53f6a96e-ca64-448a-8fca-01978f71f77a") });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new Guid("987caef1-e4fe-4bb0-9361-8e6a97f312d9") });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new Guid("0926a2e2-6d49-40b4-8919-1cca6d2ccd54") });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new Guid("e8305049-b32d-4923-b455-b7963a20a2ac") });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new Guid("b57eb9f3-c6f5-4349-9323-8b351c367e03") });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new Guid("d57c0cd8-67b0-46ff-a797-6859d22d1420") });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 537, DateTimeKind.Local), new Guid("3f3eaa2a-8b39-4844-9214-3308329d9a1a") });

            migrationBuilder.UpdateData(
                table: "ReceiveProduct",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new Guid("49213234-0a7d-4623-854f-7879d8d0e84f") });

            migrationBuilder.UpdateData(
                table: "ReceiveProduct",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new Guid("aa960296-e500-4483-ae13-7833723bf8f8") });

            migrationBuilder.UpdateData(
                table: "SaleOrder",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "OrderDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new Guid("fc84649e-80b7-42b7-8114-865b8d09473c") });

            migrationBuilder.UpdateData(
                table: "SaleOrder",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "OrderDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new Guid("54b44810-f2a0-41a8-a3b3-15f6164f4001") });

            migrationBuilder.UpdateData(
                table: "SaleOrderDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new Guid("63e59065-585a-48c6-adc8-f2447b1f9ccd") });

            migrationBuilder.UpdateData(
                table: "SaleOrderDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new Guid("2d9e51a3-3721-4a3a-8079-65013872893e") });

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new Guid("58bde419-cef2-4212-b9f8-4859444501c9") });

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new DateTime(2018, 11, 10, 21, 40, 36, 538, DateTimeKind.Local), new Guid("06aba560-81c1-4504-88d4-3707952b6369") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cb966ed6-29b6-4bfc-ae6c-c583d792e528") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2fd64a9-f8f4-4b05-a27c-cc465fd46a58") });

            migrationBuilder.UpdateData(
                table: "PersonInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("43d59a79-0930-49c9-a903-42a8ae580631") });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3328cb12-e85f-494a-a571-992765837498") });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a1bb2e7-5d4d-42cf-bb62-4db20b612072") });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14cb7140-d284-49ff-994f-acea95cadac4") });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8b51d174-cd30-4677-93a4-c74a35f64ca3") });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2760cf56-cbe1-4452-bfc5-58a1211cff2c") });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aa17caa3-6b4c-44a5-916c-256a5740dbea") });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6e8d0cab-88c4-4b1c-ab7c-8bf5a6127fb5") });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d23f0cd-4328-4b28-964e-f3231fca9c9c") });

            migrationBuilder.UpdateData(
                table: "ReceiveProduct",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("45a2980e-7e1c-498c-8f0a-6597eda54dd0") });

            migrationBuilder.UpdateData(
                table: "ReceiveProduct",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3f020c4-8cf6-4fe2-993a-5523f55bc4f5") });

            migrationBuilder.UpdateData(
                table: "SaleOrder",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "OrderDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 10, 21, 19, 38, 306, DateTimeKind.Local), new Guid("d5229d71-6e5d-4d91-8729-71046b34b239") });

            migrationBuilder.UpdateData(
                table: "SaleOrder",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "OrderDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 10, 21, 19, 38, 307, DateTimeKind.Local), new Guid("d40567d7-86b9-422d-96bd-f95dd88beed7") });

            migrationBuilder.UpdateData(
                table: "SaleOrderDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a2408f3-111a-47f4-adbe-8351ed385cd9") });

            migrationBuilder.UpdateData(
                table: "SaleOrderDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c65389e1-426e-4ed7-a4f6-69780295b645") });

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1b54aeed-4e86-4b28-a629-ffebbe288dca") });

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a1853a48-7ae0-45a3-abf1-bac47b171a8b") });
        }
    }
}
