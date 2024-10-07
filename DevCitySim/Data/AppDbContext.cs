using System;
using System.Collections.Generic;
using DevCitySim.Data.Classes;
using DevCitySim.Data.Lists;
using Microsoft.EntityFrameworkCore;

namespace DevCitySim.Data
{
    internal class AppDbContext : DbContext
    { 
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;" +
                "port=3306;" +
                "user=root;" +
                "password=;" +
                "database=csd_devcitysim",
                ServerVersion.Parse("10.4.17-mariadb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Building>()
                .HasOne(b => b.Citizen)
                .WithMany(c => c.Buildings).
                HasForeignKey(b => b.CitizenId);

            CitizenList citizensList = new CitizenList();
            BuildingList buildingList = new BuildingList();
            CarList carList = new CarList();

            List<Citizen> citizens = citizensList.GetCitizensList();
            List<Building> buildings = buildingList.GetBuildingList();
            List<Car> cars = carList.GetCarList();

            modelBuilder.Entity<Citizen>().HasData(citizens.ToArray());
            modelBuilder.Entity<Building>().HasData(buildings.ToArray());
            modelBuilder.Entity<Car>().HasData(cars.ToArray());
        }
    }
}
