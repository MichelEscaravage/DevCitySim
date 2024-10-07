using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCitySim.Data.Classes
{
    internal class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string NumberPlate { get; set; }
        public float Kilometers { get; set; }
    }
}
