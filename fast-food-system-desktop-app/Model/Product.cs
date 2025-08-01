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

        public HashSet<ProductCategory>? ProductCategories { get; set; } = new HashSet<ProductCategory>();

        [MinLength(3, ErrorMessage = "\"Name\" has to be at least 3 characters long.")]
        public string Name { get; set; }

        public enum FoodOption
        {
            Beef,
            Chicken,
            Mushroom,
            Pork,
            Shrimp,
            Tofu
        }

        public FoodOption? SelectedFoodOption { get; set; }

        public enum PopOption
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

        public PopOption? SelectedPopOption { get; set; }

        public string? Description { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "\"Price\" can not be less than zero")]
        public decimal Price { get; set; }

        public Product() { }

        public Product(string code, HashSet<ProductCategory>? productCategories, string name, FoodOption? foodOption, PopOption? popOption, string? description, decimal price)
        {
            Id = Guid.NewGuid();
            Code = code;
            ProductCategories = productCategories;
            Name = name;
            SelectedFoodOption = foodOption;
            SelectedPopOption = popOption;
            Description = description;
            Price = price;
        }
    }
}
