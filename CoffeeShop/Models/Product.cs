using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace CoffeeShop.Models
{
    [Table("imaginecoffee")]
    public class Product
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }

        public static List<Product> AllProducts = new List<Product>();
    }
}
