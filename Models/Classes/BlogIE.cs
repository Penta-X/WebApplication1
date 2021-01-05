using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Classes
{
    public class BlogIE
    {
        public IEnumerable<Blog> Value1 { get; set; }
        public IEnumerable<Blog> Value2 { get; set; }
    }
}