using fast_food_system_desktop_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_food_system_desktop_app.Data
{
    public class DefaultCart
    {
        //Id = Guid.NewGuid();
        //OrderId = orderId;
        //Order = order;
        //CartProducts = cartProducts;

        public static Cart cart = new Cart();

        public static HashSet<Cart> carts = new HashSet<Cart>()
        {
            cart
        };
    }
}
