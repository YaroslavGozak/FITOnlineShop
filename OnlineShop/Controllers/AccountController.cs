using OnlineShop.Models;
using OnlineShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    [Route("Account")]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [Route("CheckLogin")]
        public ActionResult CheckLogin(LoginModel model)
        {
            string responseMessage;
            bool success;
            if (AccountService.LoginModels.Where(m => m.Login == model.Username && m.Password == model.Password).Any())
            {
                State.Customer = AccountService.LoginModels.Single(m => m.Login == model.Username && m.Password == model.Password);
                success = true;
                responseMessage = "Success";
            }
            else
            {
                success = false;
                responseMessage = "Could not authorize";
            }
            return new JsonResult
            {
                Data = new
                {
                    success = success,
                    message = responseMessage
                }
            };
        }

        public ActionResult Logout()
        {
            State.Customer = null;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Settings()
        {
            return View("CustomerInfo", State.Customer);
        }

        public ActionResult CustomerInfo()
        {
            return View(State.Customer);
        }

        public ActionResult Orders()
        {
            return View(State.Customer);
        }
    }
}