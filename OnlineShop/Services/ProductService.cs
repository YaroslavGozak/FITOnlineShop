using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Services
{
    public static class ProductService
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
                    ImageUrl = "http://agressor.com.ua/uploads/8640/item/zoom/i3517382-1a0c1b3ab8145be503a55e1997cb20f7.jpg",
                    Category = "boots"
                },
                new Product{
                    ID = 7,
                    Description = "Ботинки на теплую летнюю погоду от немецкой компании Mil-Tec. Материал изготовления - Кожа-выворотка (очень качественная) и дышащяя синтетика. Подошва трех слойная: -Мягкий демпферный слой; Более жесткий но эластичный протектор; Пластиковый внешний супинатор. Пригодна для ходьбы по любому ландшафту. Усиленные накладки на носке и пятке в разы продлят срок службы ботинок. Сетчатая потоотводящая подкладка позволит оставаться ногам в сухости и комфорте. В комплектации идут анатомические стельки.",
                    Name = "TROOPER 5",
                    Price = 1530.00,
                    ImageUrl = "https://militarist.ua/upload/resize_cache/iblock/d6f/210_210_1/d6f8ee81f67d6ff48b011b5600df70ef.jpg",
                    Category = "boots"
                } };
        public static IEnumerable<Product> GetAllProducts()
        {
            return _mockProducts;
        }

        public static Product GetByID(int id)
        {
            return _mockProducts.FirstOrDefault(p => p.ID == id);
        }

        public static IEnumerable<Product> GetByCategory(string category)
        {
            return _mockProducts.Where(p => String.Equals(p.Category, category, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}