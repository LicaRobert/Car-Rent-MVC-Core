using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentWebApp.Migrations
{
    public partial class CarRent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarRent",
                columns: table => new
                {
                    CarRentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientID = table.Column<int>(unicode: false, maxLength: 30, nullable: false),
                    CarModel = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    StartDate = table.Column<DateTime>(unicode: false, maxLength: 50, nullable: false),
                    EndDate = table.Column<DateTime>(unicode: false, maxLength: 10, nullable: false),
                    City = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarRent", x => x.CarRentID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Plate = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Manufacturer = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Model = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PricePerDay = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CostumerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Location = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ConfirmPassword = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CostumerID);
                });


            migrationBuilder.InsertData(
               table: "Cars",
               columns: new[] { "CarId", "Plate", "Model", "Manufacturer", "PricePerDay" },
               values: new object[,]
               {
                    { 1, "BP 59 GCM", "Focus", "Ford", 408 },
                    { 2, "JA 97 ZFS", "Galant", "Mitsubishi", 85 },
                    { 3, "DJ 96 LIK", "MX5", "Mazda", 100 },
                    { 4, "EY 09 VKW", "Avensis", "Toyota", 125 },
                    { 5, "UQ 06 RBI", "CLS", "Mercedes", 448 },
                    { 6, "UP 92 HGE", "Mondeo", "Ford", 221 },
                    { 7, "SB 29 LRL", "Fiero", "Pontiac", 448 },
                    { 8, "QL 92 VYC", "Aveo", "Chevrolet", 100 },
                    { 9, "TB 64 ODA", "Astra", "Opel", 224 },
                    { 10, "MF 10 SLY", "E-Class", "Mercedes", 525 },
                    { 11, "PG 82 UGB", "Optima", "Kia", 165 },
                    { 12, "BL 98 TAX", "S-Class", "Mercedes", 731 },
                    { 13, "OU 12 ZDS", "RX-7", "Mazda", 425 },
                    { 14, "MF 10 SLY", "G-Class", "Mercedes", 625 },
                    { 15, "HO 61 FRO", "Expo", "Mitsubishi", 308 },
                    { 16, "CV 12 KCP", "Supra", "Toyota", 300 },
                    { 17, "DA 98 LFG", "Cayenne", "Porsche", 428 },
                    { 18, "SS 41 ZNC", "Leaf", "Nissan", 198 },
                    { 19, "HD 12 FRO", "Lancer", "Mitsubishi", 87 },
                    { 20, "B 888 DAR", "7-Series", "BMW", 605 }
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarRent");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CarRentViewModel");
        }
    }
}
