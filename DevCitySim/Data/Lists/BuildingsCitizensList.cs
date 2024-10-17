using DevCitySim.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCitySim.Data.Lists
{
    internal class BuildingsCitizensList
    {
        List<BuildingCitizen> buildingCitizenList = new List<BuildingCitizen>
        {
            new BuildingCitizen(1, 1),
            new BuildingCitizen(1, 4),
            new BuildingCitizen(1, 5),
            new BuildingCitizen(2, 2),
            new BuildingCitizen(2, 8),
            new BuildingCitizen(3, 3),
            new BuildingCitizen(3, 11),
            new BuildingCitizen(4, 4),
            new BuildingCitizen(4, 15),
            new BuildingCitizen(5, 1),
            new BuildingCitizen(5, 6),
            new BuildingCitizen(6, 5),
            new BuildingCitizen(6, 16),
            new BuildingCitizen(7, 3),
            new BuildingCitizen(7, 17),
            new BuildingCitizen(8, 8),
            new BuildingCitizen(8, 12),
            new BuildingCitizen(9, 11),
            new BuildingCitizen(9, 19),
            new BuildingCitizen(10, 4),
            new BuildingCitizen(10, 20),
            new BuildingCitizen(11, 13),
            new BuildingCitizen(11, 14),
            new BuildingCitizen(12, 16),
            new BuildingCitizen(12, 18),
            new BuildingCitizen(13, 14),
            new BuildingCitizen(13, 15),
            new BuildingCitizen(14, 15),
            new BuildingCitizen(14, 25),
            new BuildingCitizen(15, 25),
            new BuildingCitizen(15, 30),
            new BuildingCitizen(16, 12),
            new BuildingCitizen(16, 32),
            new BuildingCitizen(17, 17),
            new BuildingCitizen(17, 34),
            new BuildingCitizen(18, 19),
            new BuildingCitizen(18, 38),
            new BuildingCitizen(19, 9),
            new BuildingCitizen(19, 35),
            new BuildingCitizen(20, 20),
            new BuildingCitizen(20, 40)


        };
        public List<BuildingCitizen> GetBuildingCitizensList()
        {
            return buildingCitizenList;
        }
    }
   
}
