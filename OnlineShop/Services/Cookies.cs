using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Services
{
    public static class Cookies
    {
        public static T GetCookies<T>(string cookieName, HttpRequest request)
        {
            var cookie = request.Cookies.Get(cookieName);
            if (cookie == null)
                return default(T);
            var cookieValue = cookie.Value;
            var data = JsonConvert.DeserializeObject<T>(cookieValue);
            return data;
        }
    }
}