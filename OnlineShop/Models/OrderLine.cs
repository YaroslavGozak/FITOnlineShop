using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class OrderLine
    {
        public Product Product { get; set; }
        public int Count { get; set; }
    }
}