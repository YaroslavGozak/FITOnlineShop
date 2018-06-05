using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Shopping
    {
        public List<Product> Products { get; set; }
        public double Total { get
            {
                double total = 0;
                foreach (var product in Products)
                    total += product.Price;
                return total;
            }
        }
    }
}