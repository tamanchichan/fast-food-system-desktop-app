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

        public HashSet<CartProduct>? CartProducts { get; set; } = new HashSet<CartProduct>();

        public Cart() { }

        public Cart(Guid? orderId, HashSet<CartProduct>? cartProducts)
        {
            Id = Guid.NewGuid();
            OrderId = orderId;
            CartProducts = cartProducts;
        }
    }
}
