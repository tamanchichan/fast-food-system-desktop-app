using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_food_system_desktop_app.Model
{
    public class Order
    {
        public Guid Id { get; set; }

        private static int _lastOrderNumber = 1001;

        public int Number { get; set; }

        public Guid CartId { get; set; }

        public Cart Cart { get; set; }

        public Guid? CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public string? PhoneNumber { get; set; }

        public enum OrderType
        {
            [Display(Name = "Dine-In")]
            DineIn,

            [Display(Name = "Pick-Up")]
            PickUp,

            [Display(Name = "Delivery")]
            Delivery
        }

        public OrderType? Type { get; set; }

        public string? Observation { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "\"SubTotal\" can not be less than zero.")]
        public decimal SubTotal
        {
            get
            {
                return Math.Round(Cart.CartProducts.Sum(cp => cp.Price * cp.Quantity), 2);
            }
        }

        [Range(0, double.MaxValue, ErrorMessage = "\"Total\" can not be less than zero.")]
        public decimal Total
        {
            get
            {
                return Math.Round((decimal)SubTotal * 1.12m, 2);
            }
        }

        public Order()
        {
            Id = Guid.NewGuid();
            Number = _lastOrderNumber++;
        }

        public Order(Guid cartId, Cart cart, Guid? customerId, Customer? customer, string? phoneNumber, OrderType? orderType, string? observation)
        {
            Id = Guid.NewGuid();
            Number = _lastOrderNumber++;
            CartId = cartId;
            Cart = cart;
            CustomerId = customerId;
            Customer = customer;
            PhoneNumber = phoneNumber;
            Type = orderType;
            Observation = observation;
        }
    }
}
