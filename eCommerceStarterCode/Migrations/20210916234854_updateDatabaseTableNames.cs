using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileRepairMT.Migrations
{
    public partial class updateDatabaseTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ltis");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321d9e4c-ed21-4e56-80ec-3e353c955702");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4a31323-5cc3-4018-8c7c-6f82aefb120f");

            migrationBuilder.CreateTable(
                name: "EmployeeLtis",
                columns: table => new
                {
                    LtiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfVehicle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleMileage = table.Column<double>(type: "float", nullable: false),
                    VinNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Engine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clutch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carburetor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelPump = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DieselMultiFuel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Turbocharger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExhaustSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolingSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Battery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distributor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alternator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Regulator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wiring = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransferCase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriveShaft = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontAxle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkingBrake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceBrake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tires = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tracks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wheels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SteeringGear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HydraulicSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TowingConnection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShockAbsorbers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Springs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cabin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleFloor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Glass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InteriorTrim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatsAndUpholster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleAccessories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstrumentCluster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfInspection = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MechanicName = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLtis", x => x.LtiId);
                    table.ForeignKey(
                        name: "FK_EmployeeLtis_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54467362-f005-41bb-bfd6-56b4ddba45c7", "a6691417-2a35-49e8-b67e-f2ce51b3fd60", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04dd2299-0011-4808-979e-91b98caece77", "9cff8cd4-1599-4492-b1b1-4bfbad9bfd92", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLtis_OwnerId",
                table: "EmployeeLtis",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeLtis");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04dd2299-0011-4808-979e-91b98caece77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54467362-f005-41bb-bfd6-56b4ddba45c7");

            migrationBuilder.CreateTable(
                name: "Ltis",
                columns: table => new
                {
                    LtiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alternator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Battery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cabin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carburetor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clutch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolingSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfInspection = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DieselMultiFuel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distributor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriveShaft = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Engine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExhaustSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrontAxle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelPump = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Glass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HydraulicSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstrumentCluster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InteriorTrim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MechanicName = table.Column<int>(type: "int", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ParkingBrake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Regulator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatsAndUpholster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceBrake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShockAbsorbers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Springs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SteeringGear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tires = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TowingConnection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tracks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransferCase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Turbocharger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfVehicle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<int>(type: "int", nullable: false),
                    VehicleAccessories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleFloor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleMileage = table.Column<int>(type: "int", nullable: false),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VinNumber = table.Column<int>(type: "int", nullable: false),
                    Wheels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wiring = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ltis", x => x.LtiId);
                    table.ForeignKey(
                        name: "FK_Ltis_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4a31323-5cc3-4018-8c7c-6f82aefb120f", "98f0b416-e2d1-44c4-abbe-56460070c90e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "321d9e4c-ed21-4e56-80ec-3e353c955702", "d1950f5c-cfe3-4dcc-ba56-29e7ddbafc4a", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Ltis_OwnerId",
                table: "Ltis",
                column: "OwnerId");
        }
    }
}
