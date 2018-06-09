using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranMenu

{
    public class Product
    {
        public string Name { get; set;  }
        public decimal Price { get; set; }
        public byte Count { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
