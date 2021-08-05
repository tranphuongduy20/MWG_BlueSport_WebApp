﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MWG_BlueSport_WebApp.Models
{
    public class StoreModel
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string address { get; set; }
        public string operatingTime { get; set; }
        public long phoneNumber { get; set; }
        public List<string> promotion { get; set; }
        public List<string> images { get; set; }
    }
}
