using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YuShop.Models
{
    public class MyDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Costumers { get; set; }
        public MyDbContext()
        {
            
        }
    }
}