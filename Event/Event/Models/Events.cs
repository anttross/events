﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Event.Models
{
    public class Events
    {
        public int ID { get; set; }
        public string ApplicationUserID { get; set; }
        public string Event { get; set; }
        public DateTime Date { get; set; }
    }
}