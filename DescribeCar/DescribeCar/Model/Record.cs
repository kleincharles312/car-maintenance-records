using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DescribeCar.Model
{
    public class Record
    {
        
        public int RecordId { get; set; }
        [Required]
        public int CarId { get; set; }
        public DateTime? DateOfRecord {get; set; }
        [Required]
        public int Mileage { get; set; }
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }
    }
}
