using System.Collections.Generic;
using DevCitySim.Data.Classes;

namespace DevCitySim.Data.Lists
{
    internal class BuildingList
    {
        List<Building> buildingList = new List<Building>()
        {
            new Building { Id = 1, Name = "DevCityTech", Kind = "Office", Location = "NullStreet 1" },
            new Building { Id = 2, Name = "GreenBlock", Kind = "Apartment", Location = "MapleRoad 15" },
            new Building { Id = 3, Name = "CodeTower", Kind = "Office", Location = "DevAvenue 5" },
            new Building { Id = 4, Name = "DevTower", Kind = "Office", Location = "TechStreet 115" },
            new Building { Id = 5, Name = "TechHub", Kind = "Warehouse", Location = "IndustryPark 10" },
            new Building { Id = 6, Name = "DataSquare", Kind = "Data Center", Location = "SiliconValley 30" },
            new Building { Id = 7, Name = "Cloud Plaza", Kind = "Mall", Location = "CloudStreet 20" },
            new Building { Id = 8, Name = "Neon Plaza", Kind = "Mall", Location = "NeonStreet 60" },
            new Building { Id = 9, Name = "ByteLabs", Kind = "Research Center", Location = "Innovation Drive 25" },
            new Building { Id = 10, Name = "Quantum Labs", Kind = "Research Center", Location = "QuantumDrive 50" },
            new Building { Id = 11, Name = "Vertex HQ", Kind = "Corporate Office", Location = "VertexBoulevard 85" },
            new Building { Id = 12, Name = "Skyline Tower", Kind = "Apartment", Location = "BlueSky 35" },
            new Building { Id = 13, Name = "EchoTower", Kind = "Office", Location = "EchoStreet 65" },
            new Building { Id = 14, Name = "Infinity Space", Kind = "Office", Location = "TechValley 40" },
            new Building { Id = 15, Name = "Solar Center", Kind = "Office", Location = "SunshineRoad 95" },
            new Building { Id = 16, Name = "Binary Base", Kind = "Residential", Location = "MainStreet 45" },
            new Building { Id = 17, Name = "Omega Industries", Kind = "Factory", Location = "OmegaPark 80" },
            new Building { Id = 18, Name = "Pixel Park", Kind = "Entertainment", Location = "PixelLane 55" },
            new Building { Id = 19, Name = "Horizon Labs", Kind = "Research Center", Location = "HorizonStreet 90" },
            new Building { Id = 20, Name = "Crystal Heights", Kind = "Apartment", Location = "DiamondRoad 70" },
            new Building { Id = 21, Name = "SkyLoft", Kind = "Residential", Location = "CloudHeights 100" },
            new Building { Id = 22, Name = "Streamline Suites", Kind = "Hotel", Location = "StreamlineBlvd 75" },
            new Building { Id = 23, Name = "MetroPoint", Kind = "Shopping Center", Location = "MetroAvenue 105" },
            new Building { Id = 24, Name = "FusionHub", Kind = "Technology Center", Location = "FusionRoad 120" },
            new Building { Id = 25, Name = "Innovation Square", Kind = "Office", Location = "StartUpLane 130" },
            new Building { Id = 26, Name = "Civic Plaza", Kind = "Government Building", Location = "CivicSquare 110" },
            new Building { Id = 27, Name = "Hall of Justice", Kind = "Court", Location = "LibertyStreet 140" },
            new Building { Id = 28, Name = "Quantum Space", Kind = "Research Facility", Location = "ScienceRoad 150" },
            new Building { Id = 29, Name = "Xeno Tower", Kind = "Office", Location = "XenoAvenue 160" },
            new Building { Id = 30, Name = "Sunrise Apartments", Kind = "Residential", Location = "MorningRoad 170" },
            new Building { Id = 31, Name = "Aurora Complex", Kind = "Commercial", Location = "AuroraBoulevard 180" },
            new Building { Id = 32, Name = "Lunar Mall", Kind = "Mall", Location = "LunarStreet 190" },
            new Building { Id = 33, Name = "Celestial Plaza", Kind = "Mall", Location = "StarRoad 200" },
            new Building { Id = 34, Name = "Industrial Park", Kind = "Factory", Location = "FactoryRoad 210" },
            new Building { Id = 35, Name = "Omega Plant", Kind = "Manufacturing", Location = "OmegaStreet 220" },
            new Building { Id = 36, Name = "SkyTech HQ", Kind = "Office", Location = "SkyTechDrive 230" },
            new Building { Id = 37, Name = "Vertex Tower", Kind = "Corporate Office", Location = "CorporateBoulevard 240" },
            new Building { Id = 38, Name = "Innovation Hub", Kind = "Tech Incubator", Location = "InnovatorsWay 250" },
            new Building { Id = 39, Name = "Pioneers Plaza", Kind = "Office", Location = "PioneerStreet 260" },
            new Building { Id = 40, Name = "Enterprise Building", Kind = "Corporate Office", Location = "EnterpriseRoad 270" },
            new Building { Id = 41, Name = "FutureTech Center", Kind = "Research Center", Location = "FutureLane 280" },
        };

        public List<Building> GetBuildingList()
        {
            return buildingList;
        }
    }
}
