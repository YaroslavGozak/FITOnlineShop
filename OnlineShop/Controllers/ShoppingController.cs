using Newtonsoft.Json;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class ShoppingController : Controller
    {
        private string cookieName = "FITShop_ShoppingCart";
        // GET: Shopping
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddItemToCart(Product item)
        {
            var cookie = HttpContext.Request.Cookies.Get(cookieName);
            if(cookie == null)
            {
                var itemsEmptyList = new List<Product>();
                cookie = new HttpCookie(cookieName, JsonConvert.SerializeObject(itemsEmptyList));
            }
            var serializedCart = cookie.Value;
            var items = JsonConvert.DeserializeObject<List<Product>>(serializedCart);
            items.Add(item);
            cookie = new HttpCookie(cookieName, JsonConvert.SerializeObject(items));
            HttpContext.Response.Cookies.Add(cookie);
            return new JsonResult
            {
                Data = new
                {
                    success = true
                }
            };
        }
    }
}