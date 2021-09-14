using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileRepairMT.Migrations
{
    public partial class newTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f627dc17-565d-4fb9-8dd6-f9402f24e8b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbaa9047-cd1d-4737-b601-913698368a71");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7fde75a7-fd67-403a-8318-4b218d2c4a95", "65e28827-60e7-4301-8821-86f724b7f54f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c03e5c86-05ad-45e6-9992-b3405d5d66d8", "e7e9a054-50b7-49cd-ab1d-accdefd0a4c8", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fde75a7-fd67-403a-8318-4b218d2c4a95");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c03e5c86-05ad-45e6-9992-b3405d5d66d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f627dc17-565d-4fb9-8dd6-f9402f24e8b2", "c98b96ed-35e8-482e-b77c-47d815522e90", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbaa9047-cd1d-4737-b601-913698368a71", "5cd396fd-e97e-4810-9ac8-238db4bb7d79", "Admin", "ADMIN" });
        }
    }
}
