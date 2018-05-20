using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;

namespace OnlineShop.Models
{
    public class CreditCard
    {
        private string _number;

        public string Number {
            get
            {
                return FormatNumber();
            }
            set {
                _number = String.Empty;
                StringBuilder numberBuilder = new StringBuilder();
                for(var i = 0; i < value.Length; i++)
                {
                    if (Char.IsDigit(value[i]))
                        numberBuilder.Append(value[i]);
                }
                _number = numberBuilder.ToString();
            }
        }

        public string CVV { get; set; }

        public int ExpirationYear { get; set; }

        public int ExpirationMonth { get; set; }

        public string NameOnCard { get; set; }

        public string Expiration {
            get
            {
                return String.Concat(ExpirationMonth, "/", ExpirationYear);
            }
        }

        private string FormatNumber()
        {
            if (String.IsNullOrEmpty(_number))
                return "";
            return _number.Replace(_number.Substring(0, 12), new String('*',12));
        }
    }
}