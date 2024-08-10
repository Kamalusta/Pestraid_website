using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Products
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsDiscount { get; set;}
        public int DiscountRate { get; set; }        
        public string ImageUrl { get; set; }
    }
}
