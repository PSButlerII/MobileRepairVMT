using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileRepairMT.Migrations
{
    public partial class UpdateFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e36cdef-a961-4731-8cb8-20e5414a1ab2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a49f8326-3dc2-41d4-98c1-6a92726a440d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ad17797-c5c8-4093-b7d6-2ac6992c7645", "08c746a3-b27d-4cd2-bc00-b0ba7d52ebb3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04412f02-1ab2-4353-bde6-0b226108306d", "0798b74a-122b-49ad-bf80-999f07423bb2", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04412f02-1ab2-4353-bde6-0b226108306d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ad17797-c5c8-4093-b7d6-2ac6992c7645");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e36cdef-a961-4731-8cb8-20e5414a1ab2", "4d2b6e5c-0fcc-4e46-961c-34d50757fcd0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a49f8326-3dc2-41d4-98c1-6a92726a440d", "7ffb1217-7797-4df0-b419-c6e67696d8d1", "Admin", "ADMIN" });
        }
    }
}
