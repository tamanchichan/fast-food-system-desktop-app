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

        public DateTime DateOfCreation { get; set; }

        public Guid CartId { get; set; }

        public Guid? CustomerId { get; set; }

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

        public decimal DeliveryFee { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Pst { get; set; }

        public decimal Gst { get; set; }

        public decimal Total { get; set; }

        public Order()
        {
            Id = Guid.NewGuid();
            Number = _lastOrderNumber++;
            DateOfCreation = DateTime.Now;
        }

        public Order(Guid cartId, Guid? customerId, string? phoneNumber, OrderType orderType, string? observation, decimal deliveryFee, decimal subTotal, decimal pst, decimal gst, decimal total)
        {
            Id = Guid.NewGuid();
            Number = _lastOrderNumber++;
            DateOfCreation = DateTime.Now;
            CartId = cartId;
            CustomerId = customerId;
            PhoneNumber = phoneNumber;
            Type = orderType;
            Observation = observation;
            DeliveryFee = deliveryFee;
            SubTotal = subTotal;
            Pst = pst;
            Gst = gst;
            Total = total;
        }
    }
}
