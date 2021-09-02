using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileRepairMT.Migrations
{
    public partial class CreatedEmployeeLtiController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e4eeb6b-0a91-45c8-8ff3-ea97230b065a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0eaa069-6de3-49d9-9bb2-bf7b7a3cfbdd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f55097c-773f-442e-bbdd-ee58e9eff995", "f91a5763-c430-480d-83d0-c8ddee5b9198", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95b33004-79e7-41f9-a5fc-e3625c07065b", "438f30f3-394a-4106-aeff-888fce7655e0", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f55097c-773f-442e-bbdd-ee58e9eff995");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95b33004-79e7-41f9-a5fc-e3625c07065b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e4eeb6b-0a91-45c8-8ff3-ea97230b065a", "fda1c107-aa0d-4f1b-a747-fae77476ad74", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b0eaa069-6de3-49d9-9bb2-bf7b7a3cfbdd", "87224352-fc1f-48c8-9d23-6264f815b6ce", "Admin", "ADMIN" });
        }
    }
}
