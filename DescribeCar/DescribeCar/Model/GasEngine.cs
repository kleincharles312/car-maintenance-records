using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DescribeCar.Model
{
    public class GasEngine : Engine
    {
        public string BaseEngineSize { get; }
        public string Horsepower { get; }
        public int NumOfCylinders { get; }

        public GasEngine(string baseEngineSize, string horsepower, int numOfCylinders) : base("Gas")
        {
            BaseEngineSize = baseEngineSize;
            Horsepower = horsepower;
            NumOfCylinders = numOfCylinders;
        }
    }
}
