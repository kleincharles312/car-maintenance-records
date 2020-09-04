using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DescribeCar.Model;
using DescribeCar.DAO;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DescribeCar.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        private readonly IRecordsDAO recordsDAO;
        private readonly ICarDAO carDAO;

        public MaintenanceController(IRecordsDAO recordsDAO, ICarDAO carDAO)
        {
            this.recordsDAO = recordsDAO;
            this.carDAO = carDAO;
        }

        [HttpGet("{carId}")]
        public IActionResult GetCarSpecs(int carId)
        {
            VehicleSpecs specs = carDAO.GetSpecs(carId);
            if (specs != null)
            {
                return Ok(specs);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{carId}/pics")]
        public IActionResult GetPics(int carId)
        {
            List<Pic> pics = carDAO.GetPics(carId);
            if (pics.Count == 0)
            {
                return NoContent();
            }
            else if (pics == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(pics);
            }
        }

        [HttpGet("{carId}/records")]
        public IActionResult GetRecords(int carId)
        {
            List<Record> records = recordsDAO.GetRecords(carId);
            if (records.Count == 0)
            {
                return NoContent();
            }
            else if (records != null)
            {
                return Ok(records);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("{carId}/records")]
        public IActionResult AddRecord(int carId, Record record)
        {
            Record newRecord = recordsDAO.AddRecord(carId, record);
            if (newRecord != null)
            {
                // The user is not able to access a single record but only a list of records                
                return Created($"{carId}/records", record);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
