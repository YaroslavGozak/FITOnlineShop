using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Services
{
    public static class State
    {
        public static Shopping Shopping = new Shopping();
        public static Customer Customer { get; set; }
    }
}