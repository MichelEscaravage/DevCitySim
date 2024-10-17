using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCitySim.Data.Classes
{
    internal class BuildingCitizen
    {
        public int CitizenId { get; set; }

        public int BuildingId { get; set; }

        public Building Building { get; set; }
        public Citizen Citizen { get; set; }

        public BuildingCitizen(int citizenId, int buildingId) 
        {
            CitizenId = citizenId;
            BuildingId = buildingId;
        }
    }
}
