using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileRepairMT.Migrations
{
    public partial class createChatHub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6833b2b0-9c54-4de2-be21-3b90f181513e", "c6f4c066-4abd-422b-afc2-d91ec15a381d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5f75a2c-b243-4b7d-bd57-ff1313d55c39", "5a86c0da-bc5a-41bd-b701-95b8ae183243", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6833b2b0-9c54-4de2-be21-3b90f181513e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5f75a2c-b243-4b7d-bd57-ff1313d55c39");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ad17797-c5c8-4093-b7d6-2ac6992c7645", "08c746a3-b27d-4cd2-bc00-b0ba7d52ebb3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04412f02-1ab2-4353-bde6-0b226108306d", "0798b74a-122b-49ad-bf80-999f07423bb2", "Admin", "ADMIN" });
        }
    }
}
