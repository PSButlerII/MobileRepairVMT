using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileRepairMT.Migrations
{
    public partial class updateDatabaseTableCustomLtiMilageDataTypeTofloat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04dd2299-0011-4808-979e-91b98caece77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54467362-f005-41bb-bfd6-56b4ddba45c7");

            migrationBuilder.AlterColumn<float>(
                name: "VehicleMileage",
                table: "CustomerLtis",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "75122f24-baf1-4dce-92db-1e7539d4be8d", "289925c6-c477-4a2b-ac74-50078075c0ae", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3511815d-b0e3-491b-a85a-bc4864aa1a88", "8b6c892e-f202-4ab9-9146-ecaf8b4b67ea", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3511815d-b0e3-491b-a85a-bc4864aa1a88");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75122f24-baf1-4dce-92db-1e7539d4be8d");

            migrationBuilder.AlterColumn<double>(
                name: "VehicleMileage",
                table: "CustomerLtis",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54467362-f005-41bb-bfd6-56b4ddba45c7", "a6691417-2a35-49e8-b67e-f2ce51b3fd60", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04dd2299-0011-4808-979e-91b98caece77", "9cff8cd4-1599-4492-b1b1-4bfbad9bfd92", "Admin", "ADMIN" });
        }
    }
}
