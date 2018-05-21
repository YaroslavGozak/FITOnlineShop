using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Services
{
    public static class State
    {
        private static List<Product> _shopping;
        public static List<Product> Shopping;
        public static Customer Customer;
    }
}