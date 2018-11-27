using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComiShop.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "SaleOrderDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippedDate",
                table: "SaleOrder",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "OrderStatus",
                table: "SaleOrder",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "46065512-4853-49a1-b981-bfdb8808c11d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                column: "ConcurrencyStamp",
                value: "b7fc292a-a574-4dcf-8559-500c1f184ea2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "816be083-545b-4391-bf60-4780337cac20", "AQAAAAEAACcQAAAAELZz/OJb3cbqeuNze+H1djH0vkaMIGlHstBsASqx4JVzTIlg+lf51P5mJDenTU6PDw==", "ee9af272-0e86-40aa-a6a0-291f926f5a14" });

            migrationBuilder.UpdateData(
                table: "PersonInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 27, 20, 14, 34, 858, DateTimeKind.Local), new DateTime(2018, 11, 27, 20, 14, 34, 858, DateTimeKind.Local), new Guid("57d5eb02-e06c-419d-99ac-e95f5d5de2bb") });

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 27, 20, 14, 34, 859, DateTimeKind.Local), new DateTime(2018, 11, 27, 20, 14, 34, 859, DateTimeKind.Local), new Guid("0870cac0-8ae9-42b2-a046-930c07492e1a") });

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 27, 20, 14, 34, 859, DateTimeKind.Local), new DateTime(2018, 11, 27, 20, 14, 34, 859, DateTimeKind.Local), new Guid("d5ec6036-bf26-43df-af03-9c263e6e9df6") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "SaleOrderDetail",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShippedDate",
                table: "SaleOrder",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "OrderStatus",
                table: "SaleOrder",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "af5c0d68-b6d4-492b-905e-73ad34b0819d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                column: "ConcurrencyStamp",
                value: "7d615910-d2bb-48b5-beac-940ad54b5bb2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29f4b994-07e6-4e89-9f8b-086a445383ee", "AQAAAAEAACcQAAAAEN36llz6KK7SPxDQiboJegmGPuEO4AgFchNM7UzpxLrcsaY5tmqH3EUlVxv/iKqktA==", "ad94606f-7642-4770-9068-1f88d9ce6cca" });

            migrationBuilder.UpdateData(
                table: "PersonInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 26, 23, 4, 10, 773, DateTimeKind.Local), new DateTime(2018, 11, 26, 23, 4, 10, 773, DateTimeKind.Local), new Guid("441d1eac-4565-452d-a0c6-3519fabefe0e") });

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 26, 23, 4, 10, 774, DateTimeKind.Local), new DateTime(2018, 11, 26, 23, 4, 10, 774, DateTimeKind.Local), new Guid("f18fca14-a9d2-4ec4-8553-5fc9ef6e0bc9") });

            migrationBuilder.UpdateData(
                table: "Shipper",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "UniqueId" },
                values: new object[] { new DateTime(2018, 11, 26, 23, 4, 10, 774, DateTimeKind.Local), new DateTime(2018, 11, 26, 23, 4, 10, 774, DateTimeKind.Local), new Guid("2c1a3bde-3da0-4661-bf86-e1b9a546c8f0") });
        }
    }
}
