using DevCitySim.Data.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCitySim.Data.Classes
{
    internal class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Kind { get; set; }
        public string Location { get; set; }
        public ICollection<BuildingCitizen> BuildingCitizens { get; set; }
    }
}
