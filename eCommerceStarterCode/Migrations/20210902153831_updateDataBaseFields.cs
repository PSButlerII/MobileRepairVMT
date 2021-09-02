using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileRepairMT.Migrations
{
    public partial class updateDataBaseFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a40bcaa-5ae1-40bb-ba94-c4420e7b45e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbbee4ee-350a-490a-bd1c-6463a827e0b7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e4eeb6b-0a91-45c8-8ff3-ea97230b065a", "fda1c107-aa0d-4f1b-a747-fae77476ad74", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b0eaa069-6de3-49d9-9bb2-bf7b7a3cfbdd", "87224352-fc1f-48c8-9d23-6264f815b6ce", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6a40bcaa-5ae1-40bb-ba94-c4420e7b45e6", "66281880-e6cf-4a60-b2c2-34c910078197", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbbee4ee-350a-490a-bd1c-6463a827e0b7", "dbae7349-b2f3-4319-aabf-9ebc1a62b873", "Admin", "ADMIN" });
        }
    }
}
