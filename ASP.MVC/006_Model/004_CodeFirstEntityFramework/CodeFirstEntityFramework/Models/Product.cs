using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstEntityFramework.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
