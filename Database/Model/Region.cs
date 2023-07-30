﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Region
    {
        public string Country { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
