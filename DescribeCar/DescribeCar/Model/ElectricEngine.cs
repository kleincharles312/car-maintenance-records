using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DescribeCar.Model
{
    public class ElectricEngine : Engine 
    {
        public string BatterySystem { get; }
        public string Dynamo { get; }

        public ElectricEngine() : base("Electric")
        {

        } 
    }
}
