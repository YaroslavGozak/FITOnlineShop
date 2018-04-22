using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.ViewModels;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class ProductsController : Controller
    {
        static List<Product> _mockProducts = new List<Product> {
            new Product
                {
                    ID = 1,
                    Description = "Alloha this is 1 product",
                    Name = "First Product",
                    Price = 10.11,
                    ImageUrl = "https://sep.yimg.com/ay/policestuff/mechanix-wear-the-original-0-5mm-covert-glove-2.gif",
                    Category = "wear"
                },
                new Product
                {
                    ID = 2,
                    Description = "Alloha this is 2 product. Mechanic too",
                    Name = "Mechanix",
                    Price = 54.11,
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91K%2BDcGPlEL._SL1500_.jpg",
                    Category = "wear"
                },
                new Product
                {
                    ID = 3,
                    Description = "Alloha this is 3 product",
                    Name = "Third Product",
                    Price = 10.11,
                    ImageUrl = "https://sep.yimg.com/ay/policestuff/mechanix-wear-the-original-0-5mm-covert-glove-2.gif",
                    Category = "wear"
                },
                new Product
                {
                    ID = 4,
                    Description = "Alloha this is 4 product. Mechanic too",
                    Name = "Mechanix 4 in stock",
                    Price = 54.11,
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91K%2BDcGPlEL._SL1500_.jpg",
                    Category = "wear"
                },
                new Product
                {
                    ID = 5,
                    Description = "Alloha this is 5 product",
                    Name = "M-Tac Keds Olive",
                    Price = 15.71,
                    ImageUrl = "https://militarist.ua/upload/resize_cache/iblock/269/210_210_1/269310daaac2a1c179e4585d58bae613.jpg",
                    Category = "boots"
                },
                new Product
                {
                    ID = 6,
                    Description = "Alloha this is 6 product. Mechanic too",
                    Name = "M-Tac Leopard Summer",
                    Price = 53.00,
                    ImageUrl = "https://militarist.ua/upload/resize_cache/iblock/1a0/210_210_1/1a0c1b3ab8145be503a55e1997cb20f7.jpg",
                    Category = "boots"
                }};
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products(string category)
        {
            return View("Index", new ProductViewModel {
                Products = _mockProducts.Where(p => String.Equals(p.Category, category, StringComparison.InvariantCultureIgnoreCase))
            });
        }

        public ActionResult ProductInfo(int? id)
        {
            var product = _mockProducts.FirstOrDefault(p => p.ID == id);
            return View(product);
        }
    }
}