using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DescribeCar.Model
{
    public class VehicleSpecs
    {
        public int carId { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Horsepower { get; set; }
        public double ZeroToSixty { get; set; }
        public Pic pic { get; set; }
    }
}
