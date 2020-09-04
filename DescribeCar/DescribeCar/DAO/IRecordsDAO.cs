using DescribeCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DescribeCar.DAO
{
    public interface IRecordsDAO
    {
        public List<Record> GetRecords(int carId);
        public Record AddRecord(int carId, Record newRecord);

    }
}
