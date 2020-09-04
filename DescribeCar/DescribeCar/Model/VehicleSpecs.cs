using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DescribeCar.Model
{
    public class VehicleSpecs
    {
        public int carId { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        public string Color { get; set; }
        public string Transmission { get; set; }
        public string WheelSize { get; set; }        
        public string BaseEngineSize { get; set; }
    }
}
