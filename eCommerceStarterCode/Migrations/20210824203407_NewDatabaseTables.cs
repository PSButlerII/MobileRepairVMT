using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileRepairMT.Migrations
{
    public partial class NewDatabaseTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a85197de-2346-492e-861e-08b0370b485f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c073f42c-79e8-41a6-a5d7-0ed41ae7aca0");

            migrationBuilder.CreateTable(
                name: "CustomerLtis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfVehicle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleMileage = table.Column<int>(type: "int", nullable: false),
                    VinNumber = table.Column<int>(type: "int", nullable: false),
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
                    MechanicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLtis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerLtis_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ltis",
                columns: table => new
                {
                    LtiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfVehicle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleMileage = table.Column<int>(type: "int", nullable: false),
                    VinNumber = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Ltis", x => x.LtiId);
                    table.ForeignKey(
                        name: "FK_Ltis_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductShoppingCartId = table.Column<int>(type: "int", nullable: false),
                    ServiceShoppingCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.ShoppingCartId);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShopServices",
                columns: table => new
                {
                    ShopServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopServices", x => x.ShopServiceId);
                });

            migrationBuilder.CreateTable(
                name: "ProductShoppingCarts",
                columns: table => new
                {
                    ProductShoppingCartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductShoppingCarts", x => x.ProductShoppingCartId);
                    table.ForeignKey(
                        name: "FK_ProductShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductShoppingCarts_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "ShoppingCartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceShoppingCarts",
                columns: table => new
                {
                    ServiceShoppingCartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceShoppingCarts", x => x.ServiceShoppingCartId);
                    table.ForeignKey(
                        name: "FK_ServiceShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceShoppingCarts_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "ShoppingCartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    UserReview = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.UserReview);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_ShopServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "ShopServices",
                        principalColumn: "ShopServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7440f1f8-e846-43fb-9dba-a17c3270ceba", "66ff4d8f-04cd-47c5-bb92-a35fed41a966", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ee1f00f-80a6-4125-ae7a-05c6df182c22", "19c8abe4-c5a6-45e0-85ab-09443a5c7aaf", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLtis_OwnerId",
                table: "CustomerLtis",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ltis_OwnerId",
                table: "Ltis",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductShoppingCarts_ProductId",
                table: "ProductShoppingCarts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductShoppingCarts_ShoppingCartId",
                table: "ProductShoppingCarts",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ServiceId",
                table: "Reviews",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceShoppingCarts_ProductId",
                table: "ServiceShoppingCarts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceShoppingCarts_ShoppingCartId",
                table: "ServiceShoppingCarts",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerLtis");

            migrationBuilder.DropTable(
                name: "Ltis");

            migrationBuilder.DropTable(
                name: "ProductShoppingCarts");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ServiceShoppingCarts");

            migrationBuilder.DropTable(
                name: "ShopServices");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ee1f00f-80a6-4125-ae7a-05c6df182c22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7440f1f8-e846-43fb-9dba-a17c3270ceba");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c073f42c-79e8-41a6-a5d7-0ed41ae7aca0", "df8961da-91f7-4729-a4aa-312b6fcd7c8f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a85197de-2346-492e-861e-08b0370b485f", "27e54b6b-7578-4229-8a3e-7a5a5651df3b", "Admin", "ADMIN" });
        }
    }
}
