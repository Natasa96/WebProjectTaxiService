﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class DriverCreationBase
    {
        public Driver Driver { get; set; }
        public CarBase Car { get; set; }
    }
}