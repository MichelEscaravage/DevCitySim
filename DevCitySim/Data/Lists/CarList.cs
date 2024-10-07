using System.Collections.Generic;
using DevCitySim.Data.Classes;

namespace DevCitySim.Data.Lists
{
    internal class CarList
    {
        List<Car> carList = new List<Car>()
        {
            new Car { Id = 1, Brand = "Mercedes", NumberPlate = "XXL-889-WN", Kilometers = 2000.0f },
            new Car { Id = 2, Brand = "BMW", NumberPlate = "YYA-234-KM", Kilometers = 15000.5f },
            new Car { Id = 3, Brand = "Audi", NumberPlate = "XLL-532-LA", Kilometers = 1200.2f },
            new Car { Id = 4, Brand = "Tesla", NumberPlate = "ZZA-789-PL", Kilometers = 300.0f },
            new Car { Id = 5, Brand = "Toyota", NumberPlate = "BGT-312-XY", Kilometers = 100500.3f },
            new Car { Id = 6, Brand = "Honda", NumberPlate = "PLX-999-RP", Kilometers = 89000.0f },
            new Car { Id = 7, Brand = "Ford", NumberPlate = "ZXC-456-LO", Kilometers = 45000.9f },
            new Car { Id = 8, Brand = "Chevrolet", NumberPlate = "TYU-111-VB", Kilometers = 65000.7f },
            new Car { Id = 9, Brand = "Nissan", NumberPlate = "OIP-874-ED", Kilometers = 9500.6f },
            new Car { Id = 10, Brand = "Mazda", NumberPlate = "OKL-567-WQ", Kilometers = 70500.3f },
            new Car { Id = 11, Brand = "Hyundai", NumberPlate = "NBV-223-QW", Kilometers = 53000.0f },
            new Car { Id = 12, Brand = "Volkswagen", NumberPlate = "ASD-897-PO", Kilometers = 31000.8f },
            new Car { Id = 13, Brand = "Subaru", NumberPlate = "QWE-543-LK", Kilometers = 83000.1f },
            new Car { Id = 14, Brand = "Porsche", NumberPlate = "GHJ-214-KL", Kilometers = 22000.4f },
            new Car { Id = 15, Brand = "Ferrari", NumberPlate = "CDE-654-MN", Kilometers = 1200.0f },
            new Car { Id = 16, Brand = "Lamborghini", NumberPlate = "JHY-999-OP", Kilometers = 5000.3f },
            new Car { Id = 17, Brand = "Kia", NumberPlate = "ZXC-876-HJ", Kilometers = 78000.2f },
            new Car { Id = 18, Brand = "Peugeot", NumberPlate = "QAZ-134-BN", Kilometers = 67000.9f },
            new Car { Id = 19, Brand = "Renault", NumberPlate = "TGB-222-VF", Kilometers = 83000.0f },
            new Car { Id = 20, Brand = "Jaguar", NumberPlate = "PLM-333-XW", Kilometers = 14000.4f }
        };

        public List<Car> GetCarList()
        {
            return carList;
        }
    }
}
