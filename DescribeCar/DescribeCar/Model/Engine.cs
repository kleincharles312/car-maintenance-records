using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DescribeCar.Model
{
    abstract public class Engine
    {
        private static string[] basicTypes = new string[] { "Gas", "Electric", "Hydrogen", "Hybrid" };
        public string BasicEngineType { get; }

        public Engine(string basicEngineType)
        {
            if (basicTypes.Contains(basicEngineType))
            {
                BasicEngineType = basicEngineType;
            }
            else
            {
                // TODO: Handle Error Here
            }
        }
    }
}
