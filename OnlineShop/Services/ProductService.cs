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
                    Description = @"Plush Material-100% cotton shell with 100% microfiber fillings, super soft, breathable and not easy to be out of shape
No-shift Construction - Preventing filling shifting and offering more support to your head and offer stable environment for your high quality sleep
Hypoallergenic & Dust Mite Resistant - Made of user-friendly material to avoid allergenic. Protects Against dust mite, mold & mildew resistant to keep you away from any respiratory issues
Machine Washable - Easy to care, Gentle cycle, tumble dry on low heat and do not bleach, not easy to be out of shape, prevent fading and stains
Warranty Guarantee - HOMFY offers 24-month warranty from the date of the purchase with any issues",
                    Name = "Green Pillow",
                    Price = 10.11,
                    ImageUrl = "/Images/PillowGreen.jpg",
                    Category = "beds"
                },
                new Product
                {
                    ID = 2,
                    Description = @"Plush Material-100% cotton shell with 100% microfiber fillings, super soft, breathable and not easy to be out of shape
No-shift Construction - Preventing filling shifting and offering more support to your head and offer stable environment for your high quality sleep
Hypoallergenic & Dust Mite Resistant - Made of user-friendly material to avoid allergenic. Protects Against dust mite, mold & mildew resistant to keep you away from any respiratory issues
Machine Washable - Easy to care, Gentle cycle, tumble dry on low heat and do not bleach, not easy to be out of shape, prevent fading and stains
Warranty Guarantee - HOMFY offers 24-month warranty from the date of the purchase with any issues",
                    Name = "Pink Pillow",
                    Price = 54.11,
                    ImageUrl = "/Images/PillowPink.jpg",
                    Category = "beds"
                },
                new Product
                {
                    ID = 3,
                    Description = @"A spa treatment for your entire body!  The rich consistency of fresh avocado pulp, avocado oil, and lots of shea butter create a rich, creamy, skin-nourishing soap.

The avocado, a treasury of vitamins, minerals and natural oils, is used in spas to make moisturizing facial masks. 
Avocado oil and unrefined shea butter, excellent for dry, damaged and maturing skin, penetrate deep to moisturize, nourish, and give back elasticity.
Oatmeal soothes sensitive skin and exfoliates with a gentle touch
Wheatgrass, high in antioxidants, has antibacterial, anti-inflammatory and healing properties
The essential oil blend is a rich and warm scent.  
We purchase our organic oats and oat flour from Stutzman's Farms. Read more about Stutzman's Farms in the FAQs on this page.",
                    Name = "Natural Karpathin Soap",
                    Price = 10.11,
                    ImageUrl = "/Images/Soap.jpg",
                    Category = "chemicals"
                },
                new Product
                {
                    ID = 4,
                    Description = @"Greece has long history of apiary (bee-keeping). Greece has more beehives per acre than any other country in Europe. A wide biodiversity of flora combined with powerful summer sun produce this golden nectar. For many, Greek honey is regarded as one of the finest in the world. 

Honey is the first traditional sweetener used by the Greeks since antiquity. Honey along with the olive and the grape formed the beginnings of Greek gastronomy. Honey contains anti-bacterial, anti-viral and anti-fungal substances. Honey has been used for centuries as a treatment for sore throats and coughs, minor burns, cuts and other bacterial infections. 

All Oliveology bee products are raw (unpasteurised), unfiltered, unprocessed with no additives.
Our hives are located in the Laconia region around Mt. Taygetus and Mt. Parnonas. The Laconia region in the heart of the Peloponnese is renowned for its organic principles and sustainable farming methods.",
                    Name = "Honey",
                    Price = 54.11,
                    ImageUrl = "/Images/honey.jpg",
                    Category = "food"
                },
                new Product
                {
                    ID = 5,
                    Description = @"100% pure organic raw honey prepared in easy-to-dispense packaging. Certified organic by the USDA as a premium unpasteurized and unfiltered honey with no chemicals or sugar added. Family size bulk 12 oz (340 g) package for an ample supply of tasty nutritious goodness!
Straight from the hive to the bottle delivers the promise of the highest quality honey available! Prepared with the best methodologies possessing genuine certification to guarantee authenticity and nutritional value. Unlike other honey products which are ultra-filtered to increase clarity but reduce nutritional value, Maple Holistics is geographically sourced (product of Brazil) and never undergoes filtering processes which affect purity and flavor.
Careful extraction process ensures NO heat exposure (above natural hive temperatures) or filtering occurs. 100% all-natural honey is genuinely sweet and tasty for a pure, delicious flavorful experience. Versatile usage suitable for both dietary and skincare needs.
US Grade A and certified kosher (OU). Packaged in environmentally friendly, BPA free reverse-tottle plastic bottle for easy storage with the highest standards of packaging methods which ensures the honey retains it freshness and flavor.
100% Money-Back Guarantee: If for any reason at all you are unsatisfied with your 12 oz purchase of Maple Holistics Certified Organic Honey, you are eligible for a full, no-questions-asked refund. Excellent customer service from a reputed brand who prioritizes customer satisfaction.
",
                    Name = "Honey",
                    Price = 15.71,
                    ImageUrl = "/Images/honey2.jpg",
                    Category = "food"
                },
                new Product
                {
                    ID = 6,
                    Description = @"Linen waffle towel / washed linen bath / large bath linen towel / waffle bath towel / pink linen bath towel.

Light pink linen towel with comfortable hanging loop. This lightweight, pastel towel is perfect for a nice bath.

This fabric well absorbs water and becomes very soft.",
                    Name = "Linen towel",
                    Price = 53.00,
                    ImageUrl = "/Images/LinenTowel.jpg",
                    Category = "bed"
                },
                new Product{
                    ID = 7,
                    Description = @"Here is a lovely, loose fit, easy to wear linen top.

The top has short half-sleeves and falls lightly over the body. It has a round neckline with elastic.
It is simply popped on over the head and doesn't have zippers or buttons.

The blouse is neutral and can be worn with a pair of trousers, shorts, a skirt or even over a long sleeved shirt on somewhat colder days.
",
                    Name = "Linen Top",
                    Price = 1530.00,
                    ImageUrl = "/Images/LinenCloth.jpg",
                    Category = "bed"
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