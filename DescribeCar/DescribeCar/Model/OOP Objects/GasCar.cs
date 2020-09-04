using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DescribeCar.Model
{
    public class GasCar : MotorVehicle
    {
        public GasCar(string vin, string year, string make, string model, GasEngine engine, Drivetrain drivetrain)
                : base(vin, year, make, model, 4, engine, drivetrain)
        {

        }

        public override void Accelerate()
        {
            // takes longer to accelerate as opposed to electric vehicle
            if (Speed == 0)
            {
                Thread.Sleep(1000);
            }
            base.Accelerate();
        }
    }
}
