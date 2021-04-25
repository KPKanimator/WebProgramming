using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkSamples.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext()
            : base("ProductConnection")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}