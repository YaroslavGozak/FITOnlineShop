using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.ViewModels;
using OnlineShop.Models;
using OnlineShop.Services;

namespace OnlineShop.Controllers
{
    public class ProductsController : Controller
    {
        
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products(string category)
        {
            if (String.IsNullOrEmpty(category))
                return View("ProductList", new ProductViewModel
                {
                    Products = ProductService.GetAllProducts()
                });
            else
                return View("ProductList", new ProductViewModel
                {
                Products = ProductService.GetByCategory(category)
                });
        }

        public ActionResult ProductInfo(int? id)
        {
            id = id.HasValue ? id : 0;
            var product = ProductService.GetByID((int)id);
            return View(product);
        }
    }
}