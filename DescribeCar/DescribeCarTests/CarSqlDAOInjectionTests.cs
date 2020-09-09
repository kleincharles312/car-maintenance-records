using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Transactions;
using DescribeCar.DAO;
using DescribeCar.Model;

namespace DescribeCarTests
{
    [TestClass]
    public class CarSqlDAOInjectionTests
    {
        private TransactionScope tran;
        private string connectionString = @"Server=.\sqlexpress;database=car_specs; trusted_connection=true;";
        private int carId;

        [TestInitialize]
        public void StartupTests()
        {
            tran = new TransactionScope();
            string sqlTestScript = File.ReadAllText("injectionTestSetup.sql");

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlTestScript, conn);
                    carId = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [TestCleanup]
        public void CleanupTests()
        {
            tran.Dispose();
        }

        [TestMethod]
        public void CarSqlDAOReturnsAVehicleSpecsObject()
        {
            CarSqlDAO dao = new CarSqlDAO(connectionString);
            VehicleSpecs test = dao.GetSpecs(carId);
            Assert.IsNotNull(test);
            Assert.AreEqual("2003", test.Year);
            Assert.AreEqual("\"16\" diameter, 6.5\" width", test.WheelSize);
        }
    }
}
