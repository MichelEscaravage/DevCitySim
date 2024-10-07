using System.Collections.Generic;

namespace DevCitySim.Data.Lists
{
    internal class BuildingList
    {
        List<Building> buildingList = new List<Building>()
        {
            new Building { Id = 1, Name = "DevCityTech", Kind = "Office", Location = "NullStreet 1" },
            new Building { Id = 2, Name = "CodeTower", Kind = "Office", Location = "DevAvenue 5" },
            new Building { Id = 3, Name = "TechHub", Kind = "Warehouse", Location = "IndustryPark 10" },
            new Building { Id = 4, Name = "GreenBlock", Kind = "Apartment", Location = "MapleRoad 15" },
            new Building { Id = 5, Name = "Cloud Plaza", Kind = "Mall", Location = "CloudStreet 20" },
            new Building { Id = 6, Name = "ByteLabs", Kind = "Research Center", Location = "Innovation Drive 25" },
            new Building { Id = 7, Name = "DataSquare", Kind = "Data Center", Location = "SiliconValley 30" },
            new Building { Id = 8, Name = "Skyline Tower", Kind = "Apartment", Location = "BlueSky 35" },
            new Building { Id = 9, Name = "Infinity Space", Kind = "Office", Location = "TechValley 40" },
            new Building { Id = 10, Name = "Binary Base", Kind = "Residential", Location = "MainStreet 45" },
            new Building { Id = 11, Name = "Quantum Labs", Kind = "Research Center", Location = "QuantumDrive 50" },
            new Building { Id = 12, Name = "Pixel Park", Kind = "Entertainment", Location = "PixelLane 55" },
            new Building { Id = 13, Name = "Neon Plaza", Kind = "Mall", Location = "NeonStreet 60" },
            new Building { Id = 14, Name = "EchoTower", Kind = "Office", Location = "EchoStreet 65" },
            new Building { Id = 15, Name = "Crystal Heights", Kind = "Apartment", Location = "DiamondRoad 70" },
            new Building { Id = 16, Name = "Streamline Suites", Kind = "Hotel", Location = "StreamlineBlvd 75" },
            new Building { Id = 17, Name = "Omega Industries", Kind = "Factory", Location = "OmegaPark 80" },
            new Building { Id = 18, Name = "Vertex HQ", Kind = "Corporate Office", Location = "VertexBoulevard 85" },
            new Building { Id = 19, Name = "Horizon Labs", Kind = "Research Center", Location = "HorizonStreet 90" },
            new Building { Id = 20, Name = "Solar Center", Kind = "Office", Location = "SunshineRoad 95" }
        };

        public List<Building> GetBuildingList()
        {
            return buildingList;
        }
    }
}
