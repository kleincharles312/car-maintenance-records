using DescribeCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DescribeCar.DAO
{
    public interface ICarDAO
    {
        public VehicleSpecs GetSpecs(int carId);
        public List<Pic> GetPics(int carId);
    }
}
