using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins{ get; set; }
        public DbSet<Result> Results{ get; set; }
        public DbSet<Ticket> Tickets{ get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}