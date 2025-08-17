using fast_food_system_desktop_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace fast_food_system_desktop_app.Data
{
    public class DataAccess
    {
        public static readonly string ProductsFilePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Data", "products.json");

        public static HashSet<Product> Products = LoadProducts();

        public static HashSet<Product> LoadProducts()
        {
            if (!File.Exists(ProductsFilePath))
            {
                HashSet<Product> defaultProducts = DefaultProducts.appetizerProducts;
                return defaultProducts;
            }

            string json = File.ReadAllText(ProductsFilePath);

            HashSet<Product> products = JsonSerializer.Deserialize<HashSet<Product>>(json, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });

            return products;
        }

        public static void SaveProducts()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(ProductsFilePath));

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            File.WriteAllText(ProductsFilePath, JsonSerializer.Serialize(Products, options));
        }

        public static readonly string CategoriesFilePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Data", "categories.json");

        public static HashSet<Category> Categories = LoadCategories();

        public static HashSet<Category> LoadCategories()
        {
            if (!File.Exists(CategoriesFilePath))
            {
                HashSet<Category> defaultCategories = DefaultCategories.categories;
                return defaultCategories;
            }

            string json = File.ReadAllText(ProductsFilePath);

            HashSet<Category> categories = JsonSerializer.Deserialize<HashSet<Category>>(json, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });

            return categories;
        }

        public static void SaveCategories()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(CategoriesFilePath));

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            File.WriteAllText(CategoriesFilePath, JsonSerializer.Serialize(Categories, options));
        }

        //    public static readonly string CartsFilePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Data", "carts.json");

        //    public static Cart Cart = LoadCart();

        //    public static Cart LoadCart()
        //    {
        //        if (!File.Exists(CartsFilePath))
        //        {
        //           Cart defaultCart = DefaultCart.cart;
        //            return defaultCart;
        //        }

        //        string json = File.ReadAllText(CartsFilePath);

        //        Cart cart = JsonSerializer.Deserialize<Cart>(json, new JsonSerializerOptions
        //        {
        //            ReferenceHandler = ReferenceHandler.Preserve
        //        });

        //        return cart;
        //    }

        //    public static void SaveCarts()
        //    {
        //        Directory.CreateDirectory(Path.GetDirectoryName(CartsFilePath));

        //        JsonSerializerOptions options = new JsonSerializerOptions
        //        {
        //            WriteIndented = true,
        //            ReferenceHandler = ReferenceHandler.Preserve
        //        };

        //        File.WriteAllText(CartsFilePath, JsonSerializer.Serialize(Cart, options));
        //    }
    }
}
