using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Classes
{
    public class Donation
    {
        [Key]
        public int ID { get; set; }
        public int userid { get; set; }
        public int amount { get; set; }
        public bool verification { get; set; }
        public DateTime date { get; set; }
    }
}