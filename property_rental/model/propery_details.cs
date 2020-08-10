﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace property_rental.model
{
    public class propery_details
    {
        [Key]
        public int property_id { get; set; }
        public string property_name { get; set; }
        public string property_type { get; set; }
        public string property_address { get; set; }
        public decimal property_value { get; set; }
    }
}
