using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DescribeCar.Model
{
    public abstract class MotorVehicle
    {
        // another type of motorvehicle would be a motorcycle
        public string VIN { get; }
        public string Year { get; }
        public string Make { get; }
        public string Model { get; }
        public int NumOfWheels { get; }

        // Private properties that a normal user will not mess with
        private Engine engine;
        private Drivetrain drivetrain;

        //  Properties to access a behavior of the object
        //  Defaults as if sitting on the lot being viewed by customers
        public bool IsOn { get; private set; }
        public int Speed { get; private set; }
        public bool IsLightOn { get; private set; }

        public MotorVehicle(string vin, string year, string make, string model, int numOfWheels, Engine engine, Drivetrain drivetrain)
        {
            VIN = vin;
            Year = year;
            Make = make;
            Model = model;
            NumOfWheels = numOfWheels;

            this.engine = engine;
            this.drivetrain = drivetrain;

            IsOn = false;
            Speed = 0;
            IsLightOn = false;
        }

        // Behaviors of a vehicle that may differ between each different one
        virtual public void ToggleLights()
        {
            IsLightOn = !IsLightOn;
        }
        virtual public void Accelerate()
        {
            Speed++;
        }
        virtual public void Brake()
        {
            Speed--;
        }
    }
}
