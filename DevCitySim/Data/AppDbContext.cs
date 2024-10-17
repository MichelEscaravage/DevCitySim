using System;
using System.Collections.Generic;
using DevCitySim.Data.Classes;
using DevCitySim.Data.Lists;
using Microsoft.EntityFrameworkCore;
using Microsoft.UI.Xaml.Controls;

namespace DevCitySim.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<BuildingCitizen> buildingCitizens { get; set; }

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

            modelBuilder.Entity<BuildingCitizen>().HasKey(bc => new { bc.CitizenId, bc.BuildingId });

            modelBuilder.Entity<BuildingCitizen>().HasOne(bc => bc.Citizen).WithMany(c => c.BuildingCitizens).HasForeignKey(bc => bc.CitizenId);
            modelBuilder.Entity<BuildingCitizen>().HasOne(bc => bc.Building).WithMany(b => b.BuildingCitizens).HasForeignKey(bc => bc.BuildingId);

            CitizenList citizensList = new CitizenList();
            BuildingList buildingList = new BuildingList();
            CarList carList = new CarList();
            BuildingsCitizensList buildingsCitizensList = new BuildingsCitizensList();

            List<Citizen> citizens = citizensList.GetCitizensList();
            List<Building> buildings = buildingList.GetBuildingList();
            List<Car> cars = carList.GetCarList();
            List<BuildingCitizen> buildingCitizens = buildingsCitizensList.GetBuildingCitizensList();

            modelBuilder.Entity<Citizen>().HasData(citizens.ToArray());
            modelBuilder.Entity<Building>().HasData(buildings.ToArray());
            modelBuilder.Entity<Car>().HasData(cars.ToArray());
            modelBuilder.Entity<BuildingCitizen>().HasData(buildingCitizens.ToArray());
        }
    }
}
