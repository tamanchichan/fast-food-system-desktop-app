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
            new Product("1", null, null, "Deluxe Wonton Soup", null, null, "", 13.95m),
            new Product("2", null, null, "Wonton Soup", null, null, "", 6.95m),
            new Product("3", null, null, "Hot & Sour Soup", null, null, "", 13.95m),
            new Product("4", null, null, "Consome Soup", null, null, "", 3.95m),
            new Product("5", null, null, "Barbecue Pork", null, null, "", 13.45m),
            new Product("6", null, null, "Deep Fried Wonton", null, null, "", 6.50m),
            new Product("6A", null, null, "Chicken Wings", null, null, "", 14.50m),
            new Product("7", null, null, "Egg Roll", null, null, "", 1.75m),
            new Product("7A", null, null, "Spring Roll", null, null, "", 1.95m),
        };
    }
}
