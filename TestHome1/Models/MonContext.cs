using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestHome1.Models
{
    public class MonContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}