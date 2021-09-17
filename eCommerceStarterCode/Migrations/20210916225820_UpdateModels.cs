using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileRepairMT.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6833b2b0-9c54-4de2-be21-3b90f181513e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5f75a2c-b243-4b7d-bd57-ff1313d55c39");
           


            migrationBuilder.AlterColumn<string>(
                name: "VinNumber",
                table: "CustomerLtis",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "VehicleMileage",
                table: "CustomerLtis",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e00fe5b-bcc5-4cfd-b42c-629b3835dd57", "ef7cb16c-88af-4ee8-9a42-2961ced71892", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b279b838-e498-443a-8d7d-8925fdebd8be", "a3ec227a-0434-4cdb-8d43-a315d4fe9b13", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e00fe5b-bcc5-4cfd-b42c-629b3835dd57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b279b838-e498-443a-8d7d-8925fdebd8be");

            
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VinNumber",
                table: "CustomerLtis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleMileage",
                table: "CustomerLtis",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6833b2b0-9c54-4de2-be21-3b90f181513e", "c6f4c066-4abd-422b-afc2-d91ec15a381d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5f75a2c-b243-4b7d-bd57-ff1313d55c39", "5a86c0da-bc5a-41bd-b701-95b8ae183243", "Admin", "ADMIN" });
        }
    }
}
