using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileRepairMT.Migrations
{
    public partial class updateEmployeeLTITable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e00fe5b-bcc5-4cfd-b42c-629b3835dd57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b279b838-e498-443a-8d7d-8925fdebd8be");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4a31323-5cc3-4018-8c7c-6f82aefb120f", "98f0b416-e2d1-44c4-abbe-56460070c90e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "321d9e4c-ed21-4e56-80ec-3e353c955702", "d1950f5c-cfe3-4dcc-ba56-29e7ddbafc4a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321d9e4c-ed21-4e56-80ec-3e353c955702");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4a31323-5cc3-4018-8c7c-6f82aefb120f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e00fe5b-bcc5-4cfd-b42c-629b3835dd57", "ef7cb16c-88af-4ee8-9a42-2961ced71892", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b279b838-e498-443a-8d7d-8925fdebd8be", "a3ec227a-0434-4cdb-8d43-a315d4fe9b13", "Admin", "ADMIN" });
        }
    }
}
