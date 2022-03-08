using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_FrameworkCore_Console.Migrations
{
    public partial class v01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "roleId", "description", "roleName" },
                values: new object[] { 1L, "Mô tả vai trò 1", "Vai trò 1" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "roleId", "description", "roleName" },
                values: new object[] { 2L, "Mô tả vai trò 2", "Vai trò 2" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "userId", "email", "firstName", "lastName", "pass" },
                values: new object[] { 1L, "hoangmaicuong99@gmail.com", "Cuong", "Hoang", "123" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "productId", "productName", "userId" },
                values: new object[,]
                {
                    { 1L, "Sản phẩm 1", 1L },
                    { 2L, "Sản phẩm 2", 1L }
                });

            migrationBuilder.InsertData(
                table: "UserDetail",
                columns: new[] { "userDetailId", "createDay", "updateDay" },
                values: new object[] { 1L, new DateTime(2022, 5, 8, 14, 40, 52, 531, DateTimeKind.Unspecified), new DateTime(2022, 5, 8, 14, 40, 52, 531, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "roleId", "userId" },
                values: new object[] { 1L, 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "productId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "productId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "roleId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "UserDetail",
                keyColumn: "userDetailId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "roleId", "userId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "roleId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "userId",
                keyValue: 1L);
        }
    }
}
