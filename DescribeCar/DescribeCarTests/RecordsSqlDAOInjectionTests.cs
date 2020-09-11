using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Transactions;
using DescribeCar.DAO;
using DescribeCar.Model;
using System.Collections.Generic;

namespace DescribeCarTests
{
    [TestClass]
    public class RecordsSqlDAOInjectionTests
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
        public void RecordsSqlDAOReturnsListOfRecords()
        {
            RecordsSqlDAO dao = new RecordsSqlDAO(connectionString);
            List<Record> records = dao.GetRecords(carId);
            Assert.AreEqual(5, records.Count);
        }

        [TestMethod]
        public void RecordsSqlDAOReturnsListOfZeroWithInvalidCarId()
        {
            RecordsSqlDAO dao = new RecordsSqlDAO(connectionString);
            List<Record> records = dao.GetRecords(-1);
            Assert.AreEqual(0, records.Count);
        }
    }
}
