using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_food_system_desktop_app.Model
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public HashSet<CartProduct>? CartProducts { get; set; } = new HashSet<CartProduct>();

        public HashSet<ProductCategory>? ProductCategories { get; set; } = new HashSet<ProductCategory>();

        [MinLength(3, ErrorMessage = "\"Name\" has to be at least 3 characters long.")]
        public string Name { get; set; }

        public enum FoodOption // Move to separate file?
        {
            Beef,
            Chicken,
            Mushroom,
            Pork,
            Shrimp,
            Tofu
        }

        public enum PopOption // Move to separate file?
        {
            [Display(Name = "Coca-Cola")]
            Coke,

            [Display(Name = "Coca-Cola Zero")]
            CokeZero,

            [Display(Name = "Ginger Ale")]
            GingerAle,

            [Display(Name = "Iced Tea")]
            IcedTea,

            [Display(Name = "Pepsi")]
            Pepsi,

            [Display(Name = "Pepsi Zero")]
            PepsiZero,

            [Display(Name = "Root Bear")]
            RootBear,

            [Display(Name = "Sprite")]
            Sprite
        }

        public string? Description { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "\"Price\" can not be less than zero")]
        public decimal Price { get; set; }

        public bool HasOptions { get; set; }

        public Product() { }

        public Product(string code, string name, decimal price, bool hasOptions = false)
        {
            Id = Guid.NewGuid();
            Code = code;
            Name = name;
            Price = price;
            HasOptions = hasOptions;
        }

        public Product(string code, HashSet<CartProduct>? cartProducts, HashSet<ProductCategory>? productCategories, string name, string? description, decimal price, bool hasFoodOptions)
        {
            Id = Guid.NewGuid();
            Code = code;
            CartProducts = cartProducts;
            ProductCategories = productCategories;
            Name = name;
            Description = description;
            Price = price;
            HasOptions = hasFoodOptions;
        }
    }
}
