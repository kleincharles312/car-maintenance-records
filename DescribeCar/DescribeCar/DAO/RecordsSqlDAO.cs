using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using DescribeCar.Model;

namespace DescribeCar.DAO
{
    public class RecordsSqlDAO : IRecordsDAO
    {
        private string connectionString;

        public RecordsSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

       

        public List<Record> GetRecords(int carId)
        {
            List<Record> records = new List<Record>();
            const string QUERY = "Select * from record Where carId = @id";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(QUERY, conn);
                    cmd.Parameters.AddWithValue("@id", carId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        records.Add(RowToRecord(reader));
                    }
                }
            }
            catch
            {
                throw;
            }
            return records;
        }

        public Record AddRecord(int carId, Record newRecord)
        {
            const string QUERY = "Insert Into record (carId, dateOfRecord, mileage, description) Values (@carId, @dateOfRecord, @mileage, @description); Select @@Identity";
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(QUERY, conn);
                    cmd.Parameters.AddWithValue("@carId", carId);
                    cmd.Parameters.AddWithValue("@dateOfRecord", newRecord.Date);
                    cmd.Parameters.AddWithValue("@mileage", newRecord.Mileage);
                    cmd.Parameters.AddWithValue("@description", newRecord.Description);
                    int newId = Convert.ToInt32(cmd.ExecuteScalar());
                    newRecord.RecordId = newId;
                }    
            }
            catch
            {
                throw;
            }
            return newRecord;
        }        

        private Record RowToRecord(SqlDataReader reader)
        {
            Record result = new Record();
            result.RecordId = Convert.ToInt32(reader["recordId"]);
            result.CarId = Convert.ToInt32(reader["carId"]);
            result.Date = Convert.ToDateTime(reader["dateOfRecord"]);
            result.Mileage = Convert.ToInt32(reader["mileage"]);
            result.Description = Convert.ToString(reader["description"]);
            return result;
        }
    }
}
