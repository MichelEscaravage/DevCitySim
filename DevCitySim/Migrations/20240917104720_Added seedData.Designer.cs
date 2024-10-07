﻿// <auto-generated />
using System;
using DevCitySim.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevCitySim.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240917104720_Added seedData")]
    partial class AddedseedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DevCitySim.Data.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Kind")
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Buildings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Kind = "Office",
                            Location = "NullStreet 1",
                            Name = "DevCityTech"
                        },
                        new
                        {
                            Id = 2,
                            Kind = "Office",
                            Location = "DevAvenue 5",
                            Name = "CodeTower"
                        },
                        new
                        {
                            Id = 3,
                            Kind = "Warehouse",
                            Location = "IndustryPark 10",
                            Name = "TechHub"
                        },
                        new
                        {
                            Id = 4,
                            Kind = "Apartment",
                            Location = "MapleRoad 15",
                            Name = "GreenBlock"
                        },
                        new
                        {
                            Id = 5,
                            Kind = "Mall",
                            Location = "CloudStreet 20",
                            Name = "Cloud Plaza"
                        },
                        new
                        {
                            Id = 6,
                            Kind = "Research Center",
                            Location = "Innovation Drive 25",
                            Name = "ByteLabs"
                        },
                        new
                        {
                            Id = 7,
                            Kind = "Data Center",
                            Location = "SiliconValley 30",
                            Name = "DataSquare"
                        },
                        new
                        {
                            Id = 8,
                            Kind = "Apartment",
                            Location = "BlueSky 35",
                            Name = "Skyline Tower"
                        },
                        new
                        {
                            Id = 9,
                            Kind = "Office",
                            Location = "TechValley 40",
                            Name = "Infinity Space"
                        },
                        new
                        {
                            Id = 10,
                            Kind = "Residential",
                            Location = "MainStreet 45",
                            Name = "Binary Base"
                        },
                        new
                        {
                            Id = 11,
                            Kind = "Research Center",
                            Location = "QuantumDrive 50",
                            Name = "Quantum Labs"
                        },
                        new
                        {
                            Id = 12,
                            Kind = "Entertainment",
                            Location = "PixelLane 55",
                            Name = "Pixel Park"
                        },
                        new
                        {
                            Id = 13,
                            Kind = "Mall",
                            Location = "NeonStreet 60",
                            Name = "Neon Plaza"
                        },
                        new
                        {
                            Id = 14,
                            Kind = "Office",
                            Location = "EchoStreet 65",
                            Name = "EchoTower"
                        },
                        new
                        {
                            Id = 15,
                            Kind = "Apartment",
                            Location = "DiamondRoad 70",
                            Name = "Crystal Heights"
                        },
                        new
                        {
                            Id = 16,
                            Kind = "Hotel",
                            Location = "StreamlineBlvd 75",
                            Name = "Streamline Suites"
                        },
                        new
                        {
                            Id = 17,
                            Kind = "Factory",
                            Location = "OmegaPark 80",
                            Name = "Omega Industries"
                        },
                        new
                        {
                            Id = 18,
                            Kind = "Corporate Office",
                            Location = "VertexBoulevard 85",
                            Name = "Vertex HQ"
                        },
                        new
                        {
                            Id = 19,
                            Kind = "Research Center",
                            Location = "HorizonStreet 90",
                            Name = "Horizon Labs"
                        },
                        new
                        {
                            Id = 20,
                            Kind = "Office",
                            Location = "SunshineRoad 95",
                            Name = "Solar Center"
                        });
                });

            modelBuilder.Entity("DevCitySim.Data.Classes.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.Property<float>("Kilometers")
                        .HasColumnType("float");

                    b.Property<string>("NumberPlate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Mercedes",
                            Kilometers = 2000f,
                            NumberPlate = "XXL-889-WN"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "BMW",
                            Kilometers = 15000.5f,
                            NumberPlate = "YYA-234-KM"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Audi",
                            Kilometers = 1200.2f,
                            NumberPlate = "XLL-532-LA"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Tesla",
                            Kilometers = 300f,
                            NumberPlate = "ZZA-789-PL"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Toyota",
                            Kilometers = 100500.3f,
                            NumberPlate = "BGT-312-XY"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Honda",
                            Kilometers = 89000f,
                            NumberPlate = "PLX-999-RP"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Ford",
                            Kilometers = 45000.9f,
                            NumberPlate = "ZXC-456-LO"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Chevrolet",
                            Kilometers = 65000.7f,
                            NumberPlate = "TYU-111-VB"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "Nissan",
                            Kilometers = 9500.6f,
                            NumberPlate = "OIP-874-ED"
                        },
                        new
                        {
                            Id = 10,
                            Brand = "Mazda",
                            Kilometers = 70500.3f,
                            NumberPlate = "OKL-567-WQ"
                        },
                        new
                        {
                            Id = 11,
                            Brand = "Hyundai",
                            Kilometers = 53000f,
                            NumberPlate = "NBV-223-QW"
                        },
                        new
                        {
                            Id = 12,
                            Brand = "Volkswagen",
                            Kilometers = 31000.8f,
                            NumberPlate = "ASD-897-PO"
                        },
                        new
                        {
                            Id = 13,
                            Brand = "Subaru",
                            Kilometers = 83000.1f,
                            NumberPlate = "QWE-543-LK"
                        },
                        new
                        {
                            Id = 14,
                            Brand = "Porsche",
                            Kilometers = 22000.4f,
                            NumberPlate = "GHJ-214-KL"
                        },
                        new
                        {
                            Id = 15,
                            Brand = "Ferrari",
                            Kilometers = 1200f,
                            NumberPlate = "CDE-654-MN"
                        },
                        new
                        {
                            Id = 16,
                            Brand = "Lamborghini",
                            Kilometers = 5000.3f,
                            NumberPlate = "JHY-999-OP"
                        },
                        new
                        {
                            Id = 17,
                            Brand = "Kia",
                            Kilometers = 78000.2f,
                            NumberPlate = "ZXC-876-HJ"
                        },
                        new
                        {
                            Id = 18,
                            Brand = "Peugeot",
                            Kilometers = 67000.9f,
                            NumberPlate = "QAZ-134-BN"
                        },
                        new
                        {
                            Id = 19,
                            Brand = "Renault",
                            Kilometers = 83000f,
                            NumberPlate = "TGB-222-VF"
                        },
                        new
                        {
                            Id = 20,
                            Brand = "Jaguar",
                            Kilometers = 14000.4f,
                            NumberPlate = "PLM-333-XW"
                        });
                });

            modelBuilder.Entity("DevCitySim.Data.Classes.Citizen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Job")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Citizens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2001, 10, 24, 12, 20, 0, 0, DateTimeKind.Unspecified),
                            Job = "Software Developer",
                            Name = "Jane Doe"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(2001, 10, 24, 12, 20, 0, 0, DateTimeKind.Unspecified),
                            Job = "Software Developer",
                            Name = "Doety Jane"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1990, 6, 15, 14, 30, 0, 0, DateTimeKind.Unspecified),
                            Job = "Data Scientist",
                            Name = "John Smith"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1988, 12, 2, 10, 15, 0, 0, DateTimeKind.Unspecified),
                            Job = "Graphic Designer",
                            Name = "Emily Brown"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1995, 7, 22, 8, 45, 0, 0, DateTimeKind.Unspecified),
                            Job = "Software Developer",
                            Name = "Michael Johnson"
                        },
                        new
                        {
                            Id = 6,
                            DateOfBirth = new DateTime(1992, 11, 9, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Job = "Marketing Manager",
                            Name = "Olivia Williams"
                        },
                        new
                        {
                            Id = 7,
                            DateOfBirth = new DateTime(1985, 4, 3, 21, 10, 0, 0, DateTimeKind.Unspecified),
                            Job = "Software Developer",
                            Name = "Lucas Miller"
                        },
                        new
                        {
                            Id = 8,
                            DateOfBirth = new DateTime(1993, 9, 14, 16, 40, 0, 0, DateTimeKind.Unspecified),
                            Job = "HR Specialist",
                            Name = "Sophia Davis"
                        },
                        new
                        {
                            Id = 9,
                            DateOfBirth = new DateTime(1980, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Job = "Project Manager",
                            Name = "Daniel Martinez"
                        },
                        new
                        {
                            Id = 10,
                            DateOfBirth = new DateTime(2002, 5, 28, 9, 50, 0, 0, DateTimeKind.Unspecified),
                            Job = "Software Developer",
                            Name = "Isabella Garcia"
                        },
                        new
                        {
                            Id = 11,
                            DateOfBirth = new DateTime(1987, 8, 19, 13, 30, 0, 0, DateTimeKind.Unspecified),
                            Job = "Electrical Engineer",
                            Name = "Ethan Hernandez"
                        },
                        new
                        {
                            Id = 12,
                            DateOfBirth = new DateTime(1991, 3, 10, 11, 15, 0, 0, DateTimeKind.Unspecified),
                            Job = "Teacher",
                            Name = "Mia Wilson"
                        },
                        new
                        {
                            Id = 13,
                            DateOfBirth = new DateTime(1998, 5, 5, 20, 50, 0, 0, DateTimeKind.Unspecified),
                            Job = "Software Developer",
                            Name = "James Thomas"
                        },
                        new
                        {
                            Id = 14,
                            DateOfBirth = new DateTime(1994, 12, 25, 7, 35, 0, 0, DateTimeKind.Unspecified),
                            Job = "Financial Analyst",
                            Name = "Ava Anderson"
                        },
                        new
                        {
                            Id = 15,
                            DateOfBirth = new DateTime(1989, 6, 6, 15, 20, 0, 0, DateTimeKind.Unspecified),
                            Job = "Software Developer",
                            Name = "Alexander Lee"
                        },
                        new
                        {
                            Id = 16,
                            DateOfBirth = new DateTime(1996, 7, 30, 22, 5, 0, 0, DateTimeKind.Unspecified),
                            Job = "Architect",
                            Name = "Charlotte White"
                        },
                        new
                        {
                            Id = 17,
                            DateOfBirth = new DateTime(1983, 2, 12, 6, 25, 0, 0, DateTimeKind.Unspecified),
                            Job = "Civil Engineer",
                            Name = "Mason Lewis"
                        },
                        new
                        {
                            Id = 18,
                            DateOfBirth = new DateTime(1990, 1, 3, 23, 40, 0, 0, DateTimeKind.Unspecified),
                            Job = "Software Developer",
                            Name = "Ella Walker"
                        },
                        new
                        {
                            Id = 19,
                            DateOfBirth = new DateTime(2000, 11, 17, 4, 55, 0, 0, DateTimeKind.Unspecified),
                            Job = "Doctor",
                            Name = "Liam Hall"
                        },
                        new
                        {
                            Id = 20,
                            DateOfBirth = new DateTime(1984, 4, 8, 18, 20, 0, 0, DateTimeKind.Unspecified),
                            Job = "Lawyer",
                            Name = "Amelia Allen"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
