using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DescribeCar.Model
{
    public class Motorcycle : MotorVehicle
    {
        public string Style { get; }

        public Motorcycle(string vin, string year, string make, string model, Engine engine, Drivetrain drivetrain, string style)
                : base (vin, year, make, model, 2, engine, drivetrain)
        {
            Style = style;
        }
    }
}
