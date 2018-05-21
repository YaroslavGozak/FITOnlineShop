using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public List<OrderLine> Items { get; set; }

        public Address ShippingAddress { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal Total { get
            {
                decimal sum = 0;
                foreach(var item in Items)
                {
                    sum += (decimal)((item.Count) * item.Product.Price);
                }
                return sum;
            }
        }
    }
}