﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobileRepairMT.Data;

namespace MobileRepairMT.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "fb415c89-e1d9-4751-835a-e5e6c45fea01",
                            ConcurrencyStamp = "67bed00d-1863-43a2-979d-f9f4a88276f8",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "f836d69b-790a-4b46-ba4b-fc2053755839",
                            ConcurrencyStamp = "43a16376-a02f-4f13-b17a-02002749a072",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MobileRepairMT.Models.CustomerLti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AirSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alternator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Battery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cabin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carburetor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clutch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoolingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfInspection")
                        .HasColumnType("datetime2");

                    b.Property<string>("DieselMultiFuel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Distributor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriveShaft")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Engine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExhaustSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrontAxle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuelPump")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Glass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HydraulicSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstrumentCluster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InteriorTrim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lights")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MechanicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ParkingBrake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regulator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeatsAndUpholster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceBrake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShockAbsorbers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Springs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SteeringGear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tires")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TowingConnection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tracks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransferCase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transmission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Turbocharger")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfVehicle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User")
                        .HasColumnType("int");

                    b.Property<string>("VehicleAccessories")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleFloor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleMake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleMileage")
                        .HasColumnType("int");

                    b.Property<string>("VehicleModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VinNumber")
                        .HasColumnType("int");

                    b.Property<string>("Wheels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wiring")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("CustomerLtis");
                });

            modelBuilder.Entity("MobileRepairMT.Models.Lti", b =>
                {
                    b.Property<int>("LtiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AirSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alternator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Battery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cabin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carburetor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clutch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoolingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfInspection")
                        .HasColumnType("datetime2");

                    b.Property<string>("DieselMultiFuel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Distributor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriveShaft")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Engine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExhaustSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrontAxle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuelPump")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Glass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HydraulicSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstrumentCluster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InteriorTrim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lights")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MechanicName")
                        .HasColumnType("int");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ParkingBrake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regulator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeatsAndUpholster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceBrake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShockAbsorbers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Springs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SteeringGear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tires")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TowingConnection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tracks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransferCase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transmission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Turbocharger")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfVehicle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User")
                        .HasColumnType("int");

                    b.Property<string>("VehicleAccessories")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleFloor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleMake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleMileage")
                        .HasColumnType("int");

                    b.Property<string>("VehicleModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VinNumber")
                        .HasColumnType("int");

                    b.Property<string>("Wheels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wiring")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LtiId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Ltis");
                });

            modelBuilder.Entity("MobileRepairMT.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MobileRepairMT.Models.ProductShoppingCart", b =>
                {
                    b.Property<int>("ProductShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("int");

                    b.HasKey("ProductShoppingCartId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("ProductShoppingCarts");
                });

            modelBuilder.Entity("MobileRepairMT.Models.Review", b =>
                {
                    b.Property<string>("UserReview")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserReview");

                    b.HasIndex("ProductId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("MobileRepairMT.Models.ServiceShoppingCart", b =>
                {
                    b.Property<int>("ServiceShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("int");

                    b.HasKey("ServiceShoppingCartId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("ServiceShoppingCarts");
                });

            modelBuilder.Entity("MobileRepairMT.Models.ShopService", b =>
                {
                    b.Property<int>("ShopServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("ShopServiceId");

                    b.ToTable("ShopServices");
                });

            modelBuilder.Entity("MobileRepairMT.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductShoppingCartId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ServiceShoppingCartId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ShoppingCartId");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("MobileRepairMT.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MobileRepairMT.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MobileRepairMT.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileRepairMT.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MobileRepairMT.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MobileRepairMT.Models.CustomerLti", b =>
                {
                    b.HasOne("MobileRepairMT.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("MobileRepairMT.Models.Lti", b =>
                {
                    b.HasOne("MobileRepairMT.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("MobileRepairMT.Models.ProductShoppingCart", b =>
                {
                    b.HasOne("MobileRepairMT.Models.Product", "Product")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileRepairMT.Models.ShoppingCart", "ShoppingCart")
                        .WithMany()
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("MobileRepairMT.Models.Review", b =>
                {
                    b.HasOne("MobileRepairMT.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileRepairMT.Models.ShopService", "ShopService")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobileRepairMT.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId");

                    b.Navigation("Product");

                    b.Navigation("ShopService");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MobileRepairMT.Models.ServiceShoppingCart", b =>
                {
                    b.HasOne("MobileRepairMT.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("MobileRepairMT.Models.ShoppingCart", "ShoppingCart")
                        .WithMany()
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("MobileRepairMT.Models.ShoppingCart", b =>
                {
                    b.HasOne("MobileRepairMT.Models.User", "User")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MobileRepairMT.Models.Product", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("MobileRepairMT.Models.User", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("ShoppingCarts");
                });
#pragma warning restore 612, 618
        }
    }
}
