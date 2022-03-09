using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_FrameworkCore_Console.Migrations
{
    public partial class v0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    roleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    userId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DayUpdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    productId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<long>(type: "bigint", nullable: true),
                    DayCreate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.productId);
                    table.ForeignKey(
                        name: "FK_Product_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "UserDetail",
                columns: table => new
                {
                    userDetailId = table.Column<long>(type: "bigint", nullable: false),
                    createDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateDay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetail", x => x.userDetailId);
                    table.ForeignKey(
                        name: "FK_UserDetail_User_userDetailId",
                        column: x => x.userDetailId,
                        principalTable: "User",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    userId = table.Column<long>(type: "bigint", nullable: false),
                    roleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.roleId, x.userId });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_roleId",
                        column: x => x.roleId,
                        principalTable: "Role",
                        principalColumn: "roleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "roleId", "description", "roleName" },
                values: new object[,]
                {
                    { 1, "Mô tả vai trò 1", "Vai trò 1" },
                    { 2, "Mô tả vai trò 2", "Vai trò 2" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "userId", "DayCreate", "DayUpdate", "email", "firstName", "lastName", "pass" },
                values: new object[,]
                {
                    { 1L, null, null, "hoangmaicuong99@gmail.com", "Cuong", "Hoang", "123" },
                    { 2L, null, null, "cuonghm@vihatgroup.com", "Cuong", "Hoang", "123" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "productId", "DayCreate", "productName", "userId" },
                values: new object[,]
                {
                    { 1L, null, "Sản phẩm 1", 1L },
                    { 2L, null, "Sản phẩm 2", 1L },
                    { 3L, null, "Sản phẩm 3", 1L },
                    { 4L, null, "Sản phẩm 4", 1L }
                });

            migrationBuilder.InsertData(
                table: "UserDetail",
                columns: new[] { "userDetailId", "createDay", "updateDay" },
                values: new object[] { 1L, new DateTime(2022, 5, 8, 14, 40, 52, 531, DateTimeKind.Unspecified), new DateTime(2022, 5, 8, 14, 40, 52, 531, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "roleId", "userId" },
                values: new object[,]
                {
                    { 1, 1L },
                    { 2, 1L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_userId",
                table: "Product",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_userId",
                table: "UserRole",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
