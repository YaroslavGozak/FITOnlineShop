using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Address Address { get; set; }

        public CreditCard CreditCard { get; set; }

        public IEnumerable<Order> Orders { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
    }
}