using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_food_system_desktop_app.Model
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }
        //public string? FirstName { get; set; }

        //public string? LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string? Address { get; set; }

        public List<string>? Observations { get; set; } = new List<string>();

        public HashSet<Order>? Orders { get; set; } = new HashSet<Order>();

        public Customer() { }

        //public Customer(string? firstName, string? lastName, string phoneNumber, string? address, List<string>? observations, HashSet<Order>? orders)
        //{
        //    Id = Guid.NewGuid();
        //    FirstName = firstName;
        //    LastName = lastName;
        //    PhoneNumber = phoneNumber;
        //    Address = address;
        //    Observations = observations;
        //    Orders = orders;
        //}

        public Customer(string? name, string phoneNumber, string? address, List<string>? observations, HashSet<Order>? orders)
        {
            Id = Guid.NewGuid();
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            Observations = observations;
            Orders = orders;
        }
    }
}
