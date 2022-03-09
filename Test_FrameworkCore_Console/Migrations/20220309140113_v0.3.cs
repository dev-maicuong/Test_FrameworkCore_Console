using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_FrameworkCore_Console.Migrations
{
    public partial class v03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DayCreate",
                table: "Product",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "productId",
                keyValue: 1L,
                column: "DayCreate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "productId",
                keyValue: 2L,
                column: "DayCreate",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DayCreate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "productId",
                keyValue: 1L,
                column: "DayCreate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "productId",
                keyValue: 2L,
                column: "DayCreate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
