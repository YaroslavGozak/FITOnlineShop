using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Services
{
    public class AccountService
    {
        public static List<Customer> LoginModels = new List<Customer>
        {
            new Customer
            {
                CustomerID = 1,
                Login = "admin",
                Password = "admin",
                FirstName = "Yaroslav",
                LastName = "Gozak",
                Address = new Address
                {
                    Address1 = "Hrushevsky str, 28/2",
                    City = "Kiev",
                    Country = "Poland",
                    ZipCode = "01021"
                },
                Email = "gozakyaroslav@gmail.com",
                Phone = "+38 (095) 791 79 93",
                CreditCard = new CreditCard
                {
                    CVV = "333",
                    ExpirationMonth = 10,
                    ExpirationYear = 2028,
                    NameOnCard = "Yaroslav Gozak",
                    Number = "1234 1234 1234 1238"
                },
                Orders = new List<Order>
                {
                    new Order
                    {
                        OrderID = 1,
                        OrderDate = DateTime.Now.AddDays(-2),
                        Items = new List<OrderLine>
                        {
                            new OrderLine
                            {
                                Count = 1,
                                Product = ProductService.GetAllProducts().First()
                            },
                            new OrderLine
                            {
                                Count = 3,
                                Product = ProductService.GetByID(6)
                            }
                        }
                    },
                    new Order
                    {
                        OrderID = 239,
                        OrderDate = DateTime.Now.AddDays(-2),
                        ShippingAddress =  new Address
                        {
                             Address1 = "Hrushevsky str, 28/2",
                            City = "Kiev",
                            Country = "Ukraine",
                            ZipCode = "01021"
                        },
                        Items = new List<OrderLine>
                        {
                            new OrderLine
                            {
                                Count = 1,
                                Product = ProductService.GetByID(4)
                            }
                        }
                    }
                }
            },
            new Customer
            {
                Login = "Margo1998",
                Password = "MargoTheBest",
                FirstName = "Margarita",
                LastName = "Barabash"
            }
        };
    }
}