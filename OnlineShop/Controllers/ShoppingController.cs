using Newtonsoft.Json;
using OnlineShop.Models;
using OnlineShop.Services;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    [Route("Shopping")]
    public class ShoppingController : Controller
    {
        private string cookieName = "FITShop_ShoppingCart";
        Cache cache = new Cache();
        // GET: Shopping
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddItemToCart(Product item)
        {
            var fullItem = ProductService.GetByID(item.ID);
            var cookie = HttpContext.Request.Cookies.Get(cookieName);
            if (cookie == null)
            {
                var itemsEmptyList = new List<Product>();
                cookie = new HttpCookie(cookieName, JsonConvert.SerializeObject(itemsEmptyList));
            }
            var serializedCart = cookie.Value;
            var items = JsonConvert.DeserializeObject<List<Product>>(serializedCart);
            items.Add(fullItem);
            cookie = new HttpCookie(cookieName, JsonConvert.SerializeObject(items));
            HttpContext.Response.Cookies.Add(cookie);

            State.Shopping.Products = items;

            return new JsonResult
            {
                Data = new
                {
                    success = true
                }
            };
        }

        [Route("removeFromCart")]
        public ActionResult RemoveItemFromCart(string itemID)
        {
            var id = Convert.ToInt32(itemID);
            var cookie = HttpContext.Request.Cookies.Get(cookieName);
            if (cookie == null)
            {
                return new JsonResult
                {
                    Data = new
                    {
                        success = false,
                        message = "Not Found"
                    }
                };
            }
            var serializedCart = cookie.Value;
            var items = JsonConvert.DeserializeObject<List<Product>>(serializedCart);
            var item = items.FirstOrDefault(p => p.ID == id);
            if (item == null)
            {
                return new JsonResult
                {
                    Data = new
                    {
                        success = false,
                        message = "Not Found"
                    }
                };
            }
            items.Remove(item);
            cookie = new HttpCookie(cookieName, JsonConvert.SerializeObject(items));
            HttpContext.Response.Cookies.Add(cookie);

            State.Shopping.Products = items;

            return new JsonResult
            {
                Data = new
                {
                    success = true
                }
            };
        }

        public ActionResult ShoppingCart()
        {
            var savedProducs = State.Shopping.Products;
            if (savedProducs == null || !savedProducs.Any())
                return View();
            var productIDs = savedProducs.Select(stateProduct => stateProduct.ID);
            var products = ProductService.GetAllProducts().Where(p => productIDs.Contains(p.ID));
            var model = new ShoppingCartViewModel();
            var groups = savedProducs.GroupBy(i => new { id = i.ID });
            foreach (var group in groups)
            {
                model.Items.Add(new ProductCount
                {
                    Product = products.FirstOrDefault(p => p.ID == group.Key.id),
                    Count = group.Count()
                });
            }
            return View(model);
        }

        public ActionResult Checkout(Customer model)
        {
            if (!Request.IsAjaxRequest() || Request.HttpMethod == "GET")
                return View("CustomerInfo", State.Customer);
            else
            {
                cache.Add("CustomerInfo", model, null, DateTime.MaxValue, TimeSpan.FromDays(1), CacheItemPriority.Normal, null);
                return View("Checkout", model);
            }
        }

        public ActionResult Payment()
        {
            return View();
        }

        public ActionResult Review()
        {
            var info = State.Customer;
            var model = new ReviewViewModel
            {
                Info = info,
                Items = GetSelectedProducts()
            };
            return View("Checkout", model);
        }

        [HttpPost]
        public ActionResult PaymentCallback(object response)
        {
            var temp = response;
            return RedirectToAction("Index", "Home");
        }

        private List<ProductCount> GetSelectedProducts()
        {
            var savedProducs = State.Shopping.Products;
            if (savedProducs == null || !savedProducs.Any())
                return new List<ProductCount>();
            var productIDs = savedProducs.Select(stateProduct => stateProduct.ID);
            var products = ProductService.GetAllProducts().Where(p => productIDs.Contains(p.ID));
            var model = new ShoppingCartViewModel();
            var groups = savedProducs.GroupBy(i => new { id = i.ID });
            foreach (var group in groups)
            {
                model.Items.Add(new ProductCount
                {
                    Product = products.FirstOrDefault(p => p.ID == group.Key.id),
                    Count = group.Count()
                });
            }
            return model.Items;
        }
    }
}