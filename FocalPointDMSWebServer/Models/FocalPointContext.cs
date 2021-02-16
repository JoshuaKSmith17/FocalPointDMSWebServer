using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FocalPointDMSWebServer.Models
{
    public class FocalPointContext : DbContext
    {
        public FocalPointContext(DbContextOptions<FocalPointContext> options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
    }
}
