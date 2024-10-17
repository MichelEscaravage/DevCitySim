using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DevCitySim.Migrations
{
    /// <inheritdoc />
    public partial class manytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberPlate = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kilometers = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Job = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "buildingCitizens",
                columns: table => new
                {
                    CitizenId = table.Column<int>(type: "int", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buildingCitizens", x => new { x.CitizenId, x.BuildingId });
                    table.ForeignKey(
                        name: "FK_buildingCitizens_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_buildingCitizens_Citizens_CitizenId",
                        column: x => x.CitizenId,
                        principalTable: "Citizens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Kind", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Office", "NullStreet 1", "DevCityTech" },
                    { 2, "Apartment", "MapleRoad 15", "GreenBlock" },
                    { 3, "Office", "DevAvenue 5", "CodeTower" },
                    { 4, "Office", "TechStreet 115", "DevTower" },
                    { 5, "Warehouse", "IndustryPark 10", "TechHub" },
                    { 6, "Data Center", "SiliconValley 30", "DataSquare" },
                    { 7, "Mall", "CloudStreet 20", "Cloud Plaza" },
                    { 8, "Mall", "NeonStreet 60", "Neon Plaza" },
                    { 9, "Research Center", "Innovation Drive 25", "ByteLabs" },
                    { 10, "Research Center", "QuantumDrive 50", "Quantum Labs" },
                    { 11, "Corporate Office", "VertexBoulevard 85", "Vertex HQ" },
                    { 12, "Apartment", "BlueSky 35", "Skyline Tower" },
                    { 13, "Office", "EchoStreet 65", "EchoTower" },
                    { 14, "Office", "TechValley 40", "Infinity Space" },
                    { 15, "Office", "SunshineRoad 95", "Solar Center" },
                    { 16, "Residential", "MainStreet 45", "Binary Base" },
                    { 17, "Factory", "OmegaPark 80", "Omega Industries" },
                    { 18, "Entertainment", "PixelLane 55", "Pixel Park" },
                    { 19, "Research Center", "HorizonStreet 90", "Horizon Labs" },
                    { 20, "Apartment", "DiamondRoad 70", "Crystal Heights" },
                    { 21, "Residential", "CloudHeights 100", "SkyLoft" },
                    { 22, "Hotel", "StreamlineBlvd 75", "Streamline Suites" },
                    { 23, "Shopping Center", "MetroAvenue 105", "MetroPoint" },
                    { 24, "Technology Center", "FusionRoad 120", "FusionHub" },
                    { 25, "Office", "StartUpLane 130", "Innovation Square" },
                    { 26, "Government Building", "CivicSquare 110", "Civic Plaza" },
                    { 27, "Court", "LibertyStreet 140", "Hall of Justice" },
                    { 28, "Research Facility", "ScienceRoad 150", "Quantum Space" },
                    { 29, "Office", "XenoAvenue 160", "Xeno Tower" },
                    { 30, "Residential", "MorningRoad 170", "Sunrise Apartments" },
                    { 31, "Commercial", "AuroraBoulevard 180", "Aurora Complex" },
                    { 32, "Mall", "LunarStreet 190", "Lunar Mall" },
                    { 33, "Mall", "StarRoad 200", "Celestial Plaza" },
                    { 34, "Factory", "FactoryRoad 210", "Industrial Park" },
                    { 35, "Manufacturing", "OmegaStreet 220", "Omega Plant" },
                    { 36, "Office", "SkyTechDrive 230", "SkyTech HQ" },
                    { 37, "Corporate Office", "CorporateBoulevard 240", "Vertex Tower" },
                    { 38, "Tech Incubator", "InnovatorsWay 250", "Innovation Hub" },
                    { 39, "Office", "PioneerStreet 260", "Pioneers Plaza" },
                    { 40, "Corporate Office", "EnterpriseRoad 270", "Enterprise Building" },
                    { 41, "Research Center", "FutureLane 280", "FutureTech Center" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Kilometers", "NumberPlate" },
                values: new object[,]
                {
                    { 1, "Mercedes", 2000f, "XXL-889-WN" },
                    { 2, "BMW", 15000.5f, "YYA-234-KM" },
                    { 3, "Audi", 1200.2f, "XLL-532-LA" },
                    { 4, "Tesla", 300f, "ZZA-789-PL" },
                    { 5, "Toyota", 100500.3f, "BGT-312-XY" },
                    { 6, "Honda", 89000f, "PLX-999-RP" },
                    { 7, "Ford", 45000.9f, "ZXC-456-LO" },
                    { 8, "Chevrolet", 65000.7f, "TYU-111-VB" },
                    { 9, "Nissan", 9500.6f, "OIP-874-ED" },
                    { 10, "Mazda", 70500.3f, "OKL-567-WQ" },
                    { 11, "Hyundai", 53000f, "NBV-223-QW" },
                    { 12, "Volkswagen", 31000.8f, "ASD-897-PO" },
                    { 13, "Subaru", 83000.1f, "QWE-543-LK" },
                    { 14, "Porsche", 22000.4f, "GHJ-214-KL" },
                    { 15, "Ferrari", 1200f, "CDE-654-MN" },
                    { 16, "Lamborghini", 5000.3f, "JHY-999-OP" },
                    { 17, "Kia", 78000.2f, "ZXC-876-HJ" },
                    { 18, "Peugeot", 67000.9f, "QAZ-134-BN" },
                    { 19, "Renault", 83000f, "TGB-222-VF" },
                    { 20, "Jaguar", 14000.4f, "PLM-333-XW" }
                });

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "Id", "DateOfBirth", "Job", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 10, 24, 12, 20, 0, 0, DateTimeKind.Unspecified), "Software Developer", "Jane Doe" },
                    { 2, new DateTime(2001, 10, 24, 12, 20, 0, 0, DateTimeKind.Unspecified), "Software Developer", "Doety Jane" },
                    { 3, new DateTime(1990, 6, 15, 14, 30, 0, 0, DateTimeKind.Unspecified), "Data Scientist", "John Smith" },
                    { 4, new DateTime(1988, 12, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), "Graphic Designer", "Emily Brown" },
                    { 5, new DateTime(1995, 7, 22, 8, 45, 0, 0, DateTimeKind.Unspecified), "Software Developer", "Michael Johnson" },
                    { 6, new DateTime(1992, 11, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Manager", "Olivia Williams" },
                    { 7, new DateTime(1985, 4, 3, 21, 10, 0, 0, DateTimeKind.Unspecified), "Software Developer", "Lucas Miller" },
                    { 8, new DateTime(1993, 9, 14, 16, 40, 0, 0, DateTimeKind.Unspecified), "HR Specialist", "Sophia Davis" },
                    { 9, new DateTime(1980, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "Project Manager", "Daniel Martinez" },
                    { 10, new DateTime(2002, 5, 28, 9, 50, 0, 0, DateTimeKind.Unspecified), "Software Developer", "Isabella Garcia" },
                    { 11, new DateTime(1987, 8, 19, 13, 30, 0, 0, DateTimeKind.Unspecified), "Electrical Engineer", "Ethan Hernandez" },
                    { 12, new DateTime(1991, 3, 10, 11, 15, 0, 0, DateTimeKind.Unspecified), "Teacher", "Mia Wilson" },
                    { 13, new DateTime(1998, 5, 5, 20, 50, 0, 0, DateTimeKind.Unspecified), "Software Developer", "James Thomas" },
                    { 14, new DateTime(1994, 12, 25, 7, 35, 0, 0, DateTimeKind.Unspecified), "Financial Analyst", "Ava Anderson" },
                    { 15, new DateTime(1989, 6, 6, 15, 20, 0, 0, DateTimeKind.Unspecified), "Software Developer", "Alexander Lee" },
                    { 16, new DateTime(1996, 7, 30, 22, 5, 0, 0, DateTimeKind.Unspecified), "Architect", "Charlotte White" },
                    { 17, new DateTime(1983, 2, 12, 6, 25, 0, 0, DateTimeKind.Unspecified), "Civil Engineer", "Mason Lewis" },
                    { 18, new DateTime(1990, 1, 3, 23, 40, 0, 0, DateTimeKind.Unspecified), "Software Developer", "Ella Walker" },
                    { 19, new DateTime(2000, 11, 17, 4, 55, 0, 0, DateTimeKind.Unspecified), "Doctor", "Liam Hall" },
                    { 20, new DateTime(1984, 4, 8, 18, 20, 0, 0, DateTimeKind.Unspecified), "Lawyer", "Amelia Allen" }
                });

            migrationBuilder.InsertData(
                table: "buildingCitizens",
                columns: new[] { "BuildingId", "CitizenId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 2, 2 },
                    { 8, 2 },
                    { 3, 3 },
                    { 11, 3 },
                    { 4, 4 },
                    { 15, 4 },
                    { 1, 5 },
                    { 6, 5 },
                    { 5, 6 },
                    { 16, 6 },
                    { 3, 7 },
                    { 17, 7 },
                    { 8, 8 },
                    { 12, 8 },
                    { 11, 9 },
                    { 19, 9 },
                    { 4, 10 },
                    { 20, 10 },
                    { 13, 11 },
                    { 14, 11 },
                    { 16, 12 },
                    { 18, 12 },
                    { 14, 13 },
                    { 15, 13 },
                    { 15, 14 },
                    { 25, 14 },
                    { 25, 15 },
                    { 30, 15 },
                    { 12, 16 },
                    { 32, 16 },
                    { 17, 17 },
                    { 34, 17 },
                    { 19, 18 },
                    { 38, 18 },
                    { 9, 19 },
                    { 35, 19 },
                    { 20, 20 },
                    { 40, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_buildingCitizens_BuildingId",
                table: "buildingCitizens",
                column: "BuildingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "buildingCitizens");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Citizens");
        }
    }
}
