using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DescribeCar.Model
{
    public class Drivetrain
    {
        public string DrivetrainType { get; }

        private static string[] TypesAvailable = new string[] { "FWD", "RWD", "4WD", "AWD" };

        public Drivetrain(string drivetrainType)
        {
            if (TypesAvailable.Contains(drivetrainType))
            {
                DrivetrainType = drivetrainType;
            }
            //  Handle an error here
        }

    }
}
