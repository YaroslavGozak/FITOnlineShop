using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.ViewModels
{
    public class ProductCount
    {
        public Product Product { get; set; }
        public int Count { get; set; }
    }

    public class ShoppingCartViewModel
    {
        public ShoppingCartViewModel()
        {
            Items = new List<ProductCount>();
        }

        public List<ProductCount> Items { get; set; }
    }
}