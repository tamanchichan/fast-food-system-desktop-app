using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_food_system_desktop_app.Model
{
    public class Cart
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid? OrderId { get; set; }

        //public Order? Order { get; set; }

        public HashSet<CartProduct>? CartProducts { get; set; } = new HashSet<CartProduct>();

        //[Range(0, double.MaxValue, ErrorMessage = "\"SubTotal\" can not be less than zero.")]
        //public decimal SubTotal
        //{
        //    get
        //    {
        //        return Math.Round(CartProducts.Sum(cp => cp.Price * cp.Quantity), 2);
        //    }
        //}

        //[Range(0, double.MaxValue, ErrorMessage = "\"Total\" can not be less than zero.")]
        //public decimal Total
        //{
        //    get
        //    {
        //        return Math.Round((decimal)SubTotal * 1.12m, 2);
        //    }
        //}

        public Cart() { }

        //public Cart(Guid? orderId, Order? order, HashSet<CartProduct>? cartProducts)
        //{
        //    Id = Guid.NewGuid();
        //    OrderId = orderId;
        //    Order = order;
        //    CartProducts = cartProducts;
        //}

        public Cart(Guid? orderId, HashSet<CartProduct>? cartProducts)
        {
            Id = Guid.NewGuid();
            OrderId = orderId;
            CartProducts = cartProducts;
        }
    }
}
