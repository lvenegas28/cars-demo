﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class CarModel
    {        
        public string Brand { get; set; }             
        public string Model { get; set; }        
        public int Year { get; set; }
    }
}