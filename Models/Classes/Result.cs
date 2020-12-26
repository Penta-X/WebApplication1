using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Classes
{
    public class Result
    {
        [Key]
        public int ID { get; set; }
        public int userid { get; set; }
        public string sheltername { get; set; }
        public char verification { get; set; }

    }
}