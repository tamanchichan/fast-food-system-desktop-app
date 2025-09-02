using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_food_system_desktop_app.Model
{
    public class CartProduct
    {
        public Guid Id { get; set; }

        public Guid CartId { get; set; }

        public Guid ProductId { get; set; }


        public string Code { get; set; }

        public Product.FoodOption? SelectedFoodOption { get; set; }

        public Product.PopOption? SelectedPopOption { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "\"Price\" can not be less than zero.")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "\"Quantity\" can not be less than zero.")]
        public int Quantity { get; set; }

        public string? Observation { get; set; }

        public CartProduct() { }

        public CartProduct(Guid cartId, Guid productId, string code, Product.FoodOption foodOption, Product.PopOption popOption, decimal price, int quantity, string? observation)
        {
            Id = Guid.NewGuid();
            CartId = cartId;
            ProductId = productId;
            Code = code;
            SelectedFoodOption = foodOption;
            SelectedPopOption = popOption;
            Price = price;
            Quantity = quantity;
            Observation = observation;
        }
    }
}
