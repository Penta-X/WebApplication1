using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Classes
{
    public class Blog
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string image { get; set; }
        public DateTime date { get; set; }
    }
}