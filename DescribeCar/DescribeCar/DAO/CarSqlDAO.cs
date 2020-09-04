using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using DescribeCar.Model;

namespace DescribeCar.DAO
{
    public class CarSqlDAO : ICarDAO
    {
        private string connectionString;

        public CarSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public VehicleSpecs GetSpecs(int carId)
        {
            VehicleSpecs specs = new VehicleSpecs();
            const string QUERY = "Select * from specs Where carId = @id";
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
                        specs = RowToSpecs(reader);
                    }
                }
            }
            catch
            {
                throw;
            }
            return specs;
        }

        public List<Pic> GetPics(int carId)
        {
            List<Pic> pics = new List<Pic>();
            const string QUERY = "Select * from pic Where carId = @id";
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
                        pics.Add(RowToPic(reader));
                    }
                }
            }
            catch
            {
                throw;
            }
            return pics;
        }

        private VehicleSpecs RowToSpecs(SqlDataReader reader)
        {
            VehicleSpecs result = new VehicleSpecs();
            result.carId = Convert.ToInt32(reader["carId"]);
            result.Year = Convert.ToString(reader["yearMade"]);
            result.Make = Convert.ToString(reader["make"]);
            result.Model = Convert.ToString(reader["model"]);
            result.Color = Convert.ToString(reader["color"]);
            result.Transmission = Convert.ToString(reader["transmission"]);
            result.WheelSize = Convert.ToString(reader["wheelSize"]);
            result.BaseEngineSize = Convert.ToString(reader["baseEngineSize"]);
            return result;
        }

        private Pic RowToPic(SqlDataReader reader)
        {
            Pic result = new Pic();
            result.PicId = Convert.ToInt32(reader["picId"]);
            result.CarId = Convert.ToInt32(reader["carId"]);
            result.URL = Convert.ToString(reader["picURL"]);
            result.Alt = Convert.ToString(reader["picAlt"]);
            return result;
        }
    }
}
