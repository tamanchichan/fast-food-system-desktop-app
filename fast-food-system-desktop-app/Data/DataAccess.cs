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
                HashSet<Product> defaultProducts = DefaultProducts.products;
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

            string json = File.ReadAllText(CategoriesFilePath);

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

        public static readonly string CustomersFilePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Data", "customers.json");

        public static HashSet<Customer> Customers = LoadCustomers();

        public static HashSet<Customer> LoadCustomers()
        {
            if (!File.Exists(CustomersFilePath))
            {
                HashSet<Customer> defaultCustomers = DefaultCustomers.customers;
                return defaultCustomers;
            }

            string json = File.ReadAllText(CustomersFilePath);

            HashSet<Customer> customers = JsonSerializer.Deserialize<HashSet<Customer>>(json, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });

            return customers;
        }

        public static void SaveCustomers()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(CustomersFilePath));
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };
            File.WriteAllText(CustomersFilePath, JsonSerializer.Serialize(Customers, options));
        }

        public static readonly string CartsFilePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Data", "carts.json");

        public static HashSet<Cart> Carts = LoadCarts();

        public static HashSet<Cart> LoadCarts()
        {
            if (!File.Exists(CartsFilePath))
            {
                HashSet<Cart> defaultCarts = DefaultCarts.carts;
                return defaultCarts;
            }

            string json = File.ReadAllText(CartsFilePath);

            HashSet<Cart> carts = JsonSerializer.Deserialize<HashSet<Cart>>(json, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });

            return carts;
        }

        public static void SaveCarts()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(CartsFilePath));

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            File.WriteAllText(CartsFilePath, JsonSerializer.Serialize(Carts, options));
        }

        public static Cart Cart = GetLastCart();

        public static Cart GetLastCart()
        {
            if (Carts.Count == 0)
            {
                Cart defaultCart = new Cart();
                return defaultCart;
            }

            Cart lastCart = Carts.Last();
            DefaultCarts.cart = lastCart;

            return lastCart;
        }

        public static readonly string OrdersFilePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Data", "orders.json");

        public static HashSet<Order> Orders = LoadOrders();

        public static HashSet<Order> LoadOrders()
        {
            if (!File.Exists(OrdersFilePath))
            {
                return new HashSet<Order>() { };
            }

            string json = File.ReadAllText(OrdersFilePath);

            HashSet<Order> orders = JsonSerializer.Deserialize<HashSet<Order>>(json, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });

            return orders;
        }

        public static void SaveOrders()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(OrdersFilePath));

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };
            File.WriteAllText(OrdersFilePath, JsonSerializer.Serialize(Orders, options));
        }
    }
}
