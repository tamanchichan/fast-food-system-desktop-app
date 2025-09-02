using fast_food_system_desktop_app.Model;
using fast_food_system_desktop_app.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static fast_food_system_desktop_app.Model.Product;

namespace fast_food_system_desktop_app.Data
{
    public class DefaultProducts
    {
        //Id = Guid.NewGuid();
        //Code = code;
        //ProductCategories = productCategories;
        //Name = name;
        //SelectedFoodOption = foodOption;
        //SelectedPopOption = popOption;
        //Description = description;
        //Price = price;

        public static HashSet<Product> appetizerProducts = new HashSet<Product>()
        {
            new Product("1", "Deluxe Wonton Soup", 13.95m),
            new Product("2", "Wonton Soup", 6.95m),
            new Product("3", "Hot & Sour Soup", 13.95m),
            new Product("4", "Consomme Soup", 3.45m),
            new Product("5", "Barbecue Pork", 11.45m),
            new Product("6", "Deep Fried Wontons", 6.50m),
            new Product("6A", "Chicken Wings", 14.50m),
            new Product("7", "Egg Roll", 1.75m),
            new Product("7A", "Spring Roll", 1.95m),

        };

        public static HashSet<Product> mixedGreensProducts = new HashSet<Product>()
        {
            new Product("8", "Deluxe Mixed Greens", 15.50m),
            new Product("8A", "Deluxe Snow Peas", 15.50m),
            new Product("9", "Shrimp Mixed Greens", 15.50m),
            new Product("9A", "Shrimp with Snow Peas", 15.50m),
            new Product("9B", "Fish with Snow Peas", 15.50m),
            new Product("9C", "Squid with Snow Peas", 15.50m),
            new Product("10", "Mixed Greens with", 13.95m, true),
            new Product("10A", "Snow Peas with", 13.95m, true),
            new Product("11", "Vegetarian Mixed Greens", 10.95m),
            new Product("11A", "Deep Fried Tofu with Black Bean Garlic Sauce", 13.95m),
            new Product("12", "Beef Broccoli", 14.50m),
            new Product("12A", "Beef Gai Lan", 15.50m),
            new Product("12B", "Gai Lan with Oyster Sauce", 13.95m)
        };

        public static HashSet<Product> noodlesProducts = new HashSet<Product>()
        {
            new Product("13", "Cantonese Chow Mein", 16.50m),
            new Product("14", "Shrimp Chow Mein", 16.50m),
            new Product("15", "Chow Mein with", 14.50m, true),
            new Product("16", "Vegetarian Chow Mein", 12.50m),
            new Product("16A", "Plain Lo Mein", 12.50m),
            new Product("17", "Deluxe Shangai Noodles", 15.50m),
            new Product("17B", "Beef Shangai Noodles", 15.50m),
            new Product("18", "Deluxe Rice Noodles", 15.50m),
            new Product("18A", "Pan Fried Beef Ho Fan", 15.50m),
            new Product("18B", "Pan Fried Beef Ho Fan with Black Bean Garlic Sauce", 15.50m),
            new Product("19", "Lo Mein with", 14.50m, true),
            new Product("19A", "Deluxe Lo Mein", 15.50m),
            new Product("20", "Deluxe Singapore Noodles", 15.50m),
        };

        public static HashSet<Product> products = new HashSet<Product>(
            appetizerProducts
            .Concat(mixedGreensProducts)
            .Concat(noodlesProducts)
            );
    }
}
