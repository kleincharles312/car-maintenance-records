﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DescribeCar.Model
{
    public class Pic
    {
        public int PicId { get; set; }
        [Required]
        public int CarId { get; set; }
        [Required]
        public string URL { get; set; }
        [Required]
        public string Alt { get; set; }
    }
}
