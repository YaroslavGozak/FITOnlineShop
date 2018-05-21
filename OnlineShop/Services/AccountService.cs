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
                
                Login = "admin",
                Password = "admin",
                FirstName = "Yaroslav",
                LastName = "Gozak",
                Address = new Address
                {
                    Address1 = "Hrushevsky str, 28/2",
                    City = "Kiev",
                    Country = "Ukraine",
                    ZipCode = "01021"
                },
                Email = "gozakyaroslav@gmail.com",
                Orders = new List<Order>
                {
                    new Order
                    {
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
                                Product = ProductService.GetByID(5)
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