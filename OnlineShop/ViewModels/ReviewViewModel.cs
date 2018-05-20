using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.ViewModels
{
    public class ReviewViewModel
    {
        public Customer Info { get; set; }

        public IEnumerable<ProductCount> Items { get; set; }
    }
}