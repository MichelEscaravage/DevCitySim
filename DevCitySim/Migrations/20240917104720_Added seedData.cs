using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DevCitySim.Migrations
{
    /// <inheritdoc />
    public partial class AddedseedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Kind", "Location", "Name" },
                values: new object[,]
                {
                    { 2, "Office", "DevAvenue 5", "CodeTower" },
                    { 3, "Warehouse", "IndustryPark 10", "TechHub" },
                    { 4, "Apartment", "MapleRoad 15", "GreenBlock" },
                    { 5, "Mall", "CloudStreet 20", "Cloud Plaza" },
                    { 6, "Research Center", "Innovation Drive 25", "ByteLabs" },
                    { 7, "Data Center", "SiliconValley 30", "DataSquare" },
                    { 8, "Apartment", "BlueSky 35", "Skyline Tower" },
                    { 9, "Office", "TechValley 40", "Infinity Space" },
                    { 10, "Residential", "MainStreet 45", "Binary Base" },
                    { 11, "Research Center", "QuantumDrive 50", "Quantum Labs" },
                    { 12, "Entertainment", "PixelLane 55", "Pixel Park" },
                    { 13, "Mall", "NeonStreet 60", "Neon Plaza" },
                    { 14, "Office", "EchoStreet 65", "EchoTower" },
                    { 15, "Apartment", "DiamondRoad 70", "Crystal Heights" },
                    { 16, "Hotel", "StreamlineBlvd 75", "Streamline Suites" },
                    { 17, "Factory", "OmegaPark 80", "Omega Industries" },
                    { 18, "Corporate Office", "VertexBoulevard 85", "Vertex HQ" },
                    { 19, "Research Center", "HorizonStreet 90", "Horizon Labs" },
                    { 20, "Office", "SunshineRoad 95", "Solar Center" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Kilometers", "NumberPlate" },
                values: new object[,]
                {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
