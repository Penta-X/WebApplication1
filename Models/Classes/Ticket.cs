﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Classes
{
    public class Ticket
    {
        [Key]
        public int ID { get; set; }
        public User userid { get; set; }
        public string text { get; set; }
        public DateTime date { get; set; }
        public string response { get; set; }

    }
}