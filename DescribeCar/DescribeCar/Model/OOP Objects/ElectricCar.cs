using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DescribeCar.Model
{
    public class ElectricCar : MotorVehicle
    {
        public ElectricCar(string vin, string year, string make, string model, ElectricEngine engine, Drivetrain drivetrain)
                : base(vin, year, make, model, 4, engine, drivetrain)
        {

        }
    }
}
