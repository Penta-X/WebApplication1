using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Classes
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string birthdate { get; set; }
        public string idnumber { get; set; }
        public string income { get; set; }
        public char sheltertype { get; set; }
        public string phonenumber { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public string familycode { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

    }
}