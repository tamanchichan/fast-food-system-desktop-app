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
            new Product("7A", "Spring Roll", 1.95m)
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
            new Product("11A", "Tofu with Black Bean Garlic Sauce", 13.95m),
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
            new Product("18A", "Beef Ho Fan", 15.50m),
            new Product("18B", "Beef Ho Fan with Black Bean Garlic Sauce", 15.50m),
            new Product("19", "Lo Mein with", 14.50m, true),
            new Product("19A", "Deluxe Lo Mein", 15.50m),
            new Product("20", "Deluxe Singapore Noodles", 15.50m)
        };

        public static HashSet<Product> riceProducts = new HashSet<Product>()
        {
            new Product("21", "Deluxe Fried Rice", 14.50m),
            new Product("22", "Shrimp Fried Rice", 14.50m),
            new Product("23", "Fried Rice with", 11.50m, true),
            new Product("24", "Vegetarian Fried Rice", 12.50m),
            new Product("24A", "Plain Fried Rice", 12.50m),
            new Product("25S", "Small Steamed Rice", 2.50m),
            new Product("25L", "Large Steamed Rice", 5.00m)
        };

        public static HashSet<Product> chopSueyProducts = new HashSet<Product>()
        {
            new Product("26", "Deluxe Chop Suey", 14.50m),
            new Product("27", "Shrimp Chop Suey", 14.50m),
            new Product("28", "Chop Suey with", 13.50m, true),
            new Product("29", "Vegetarian Chop Suey", 11.50m)
        };

        public static HashSet<Product> eggFooYungProducts = new HashSet<Product>()
        {
            new Product("30", "Deluxe Egg Foo Yung", 14.50m),
            new Product("31", "Shrimp Egg Foo Yung", 14.50m),
            new Product("32", "Egg Foo Yung with", 13.50m, true),
            new Product("33", "Vegetarian Egg Foo Yung", 11.50m)
        };

        public static HashSet<Product> seaFoodProducts = new HashSet<Product>()
        {
            new Product("34", "Breaded Shrimp", 16.50m),
            new Product("34A", "Breaded Fish Fillet", 14.50m),
            new Product("34B", "Breaded Squid", 16.50m),
            new Product("35", "Black Bean Garlic Shrimp", 16.50m),
            new Product("35A", "Squid with Black Bean Garlic Sauce", 16.50m),
            new Product("35B", "Fish with Black Bean Garlic Sauce", 15.50m),
            new Product("36", "Deep Fried Shrimp", 16.50m),
            new Product("36A", "Deep Fried Fish Fillet", 14.50m),
            new Product("36B", "Deep Fried Squid", 16.50m),
            new Product("36C", "Squid with Green Onions & Ginger", 16.50m),
            new Product("37", "Sweet & Sour Shrimp", 15.50m),
            new Product("37A", "Sweet & Sour Fish Fillet", 14.50m),
            new Product("38", "Pan Fried Shrimp", 16.50m),
            new Product("39", "Spicy Garlic Shrimp", 16.50m)
        };

        public static HashSet<Product> chickenProducts = new HashSet<Product>()
        {
            new Product("40", "Sweet & Sour Chicken Balls", 14.50m),
            new Product("41", "Honey Garlic Chicken Balls", 14.50m),
            new Product("41A", "Deep Fried Sliced Chicken with Honey Garlic Sauce", 14.50m),
            new Product("42", "Hot Honey Glazed Chicken Balls", 14.50m),
            new Product("42A", "Deep Fried Sliced Chicken with Hot Honey Garlic Sauce", 14.50m),
            new Product("43", "Mushroom Chicken Balls", 14.50m),
            new Product("44", "Honey Lemon Chicken", 14.50m),
            new Product("44A", "Sliced Chicken with Mushroom", 14.50m),
            new Product("45", "Breaded Almond Chicken", 14.50m),
            new Product("45A", "Dry Breaded Chicken", 14.50m),
            new Product("46", "Sliced Chicken with Black Bean Garlic Sauce", 14.50m),
            new Product("46A", "Sliced Chicken with Green Onions & Ginger", 14.50m)
        };

        public static HashSet<Product> beefAndPorkProducts = new HashSet<Product>()
        {
            new Product("47", "Breaded Veal", 15.50m),
            new Product("48", "Hot Honey Glazed Veal", 15.50m),
            new Product("49", "Honey Garlic Veal", 15.50m),
            new Product("49A", "Beef with Honey Garlic Sauce", 15.50m),
            new Product("50", "Breaded Pork", 11.50m),
            new Product("50A", "Sweet & Sour Pork", 13.50m),
            new Product("51", "Honey Garlic Pork", 13.50m),
            new Product("52", "Breaded Spareribs", 15.50m),
            new Product("53", "Honey Garlic Spareribs", 15.50m),
            new Product("54", "Sweet & Sour Spareribs", 13.50m),
            new Product("55", "Spareribs with Black Bean Garlic Sauce", 15.50m),
            new Product("55A", "Pork with with Black Bean Garlic Sauce", 13.50m),
            new Product("56", "Beef with Black Bean Garlic Sauce", 15.50m),
            new Product("56A", "Beef with Green Onions & Ginger", 15.50m),
            new Product("56B", "Mushroom & Beef Stir-Fry", 15.50m),
            new Product("56C", "Pork with Green Onions & Ginger", 13.50m)
        };

        public static HashSet<Product> hotAndSpicyProducts = new HashSet<Product>()
        {
            new Product("57", "Szechuan Shrimp", 16.50m),
            new Product("57A", "Szechuan Fish Fillet", 14.50m),
            new Product("57B", "Szechuan Squid", 16.50m),
            new Product("58", "Szechuan Beef", 15.50m),
            new Product("59", "Szechuan Chicken", 14.50m),
            new Product("60", "Ginger Beef", 15.50m),
            new Product("61", "Ginger Chicken", 14.50m),
            new Product("62", "Curry Shrimp", 16.50m),
            new Product("62A", "Curry Squid", 16.50m),
            new Product("63", "Curry Beef", 15.50m),
            new Product("64", "Curry Chicken", 14.50m),
            new Product("65", "Kung Pao Beef", 15.50m),
            new Product("66", "Kung Pao Chicken", 14.50m),
            new Product("66A", "Sesame Chicken", 14.50m),
            new Product("67", "Salt & Pepper Chicken", 14.50m),
            new Product("67A", "Salt & Pepper Fish Fillet", 14.50m),
            new Product("67B", "Salt & Pepper Squid", 16.50m),
            new Product("68", "Salt & Pepper Shrimp", 16.50m),
            new Product("68A", "Kung Pao Shrimp", 16.50m),
            new Product("69", "Salt & Pepper Tofu", 13.50m),
            new Product("70", "Kung Pao Tofu", 13.50m),
            new Product("71", "Tofu with Beef & Mixed Greens", 14.50m),
            new Product("72", "Beef in Satay Sauce", 15.50m),
            new Product("73", "Chicken in Satay Sauce", 14.50m),
            new Product("74", "Pork in Satay Sauce", 13.50m),
            new Product("75", "Shrimp in Satay Sauce", 16.50m),
            new Product("76", "Squid in Satay Sauce", 16.50m),
            new Product("77", "Fish in Satay Sauce", 14.50m)
        };

        public static HashSet<Product> comboPlateProducts = new HashSet<Product>()
        {
            new Product("A", "Combo A", 15.50m),
            new Product("B", "Combo B", 14.50m),
            new Product("C", "Combo C", 14.50m),
            new Product("D", "Combo D", 15.50m),
            new Product("E", "Combo E", 14.50m),
            new Product("F", "Combo F", 15.50m)
        };

        public static HashSet<Product> familyDinnerProducts = new HashSet<Product>()
        {
            new Product("F2", "For Two", 38.50m),
            new Product("F3", "For Three", 56.50m),
            new Product("F4", "For Four", 71.50m),
            new Product("F5", "For Five", 87.50m),
            new Product("F6", "For Six", 104.50m)
        };

        public static HashSet<Product> products = new HashSet<Product>(
            appetizerProducts
            .Concat(mixedGreensProducts)
            .Concat(noodlesProducts)
            .Concat(riceProducts)
            .Concat(chopSueyProducts)
            .Concat(eggFooYungProducts)
            .Concat(seaFoodProducts)
            .Concat(chickenProducts)
            .Concat(beefAndPorkProducts)
            .Concat(hotAndSpicyProducts)
            .Concat(comboPlateProducts)
            .Concat(familyDinnerProducts)
            );
    }
}
