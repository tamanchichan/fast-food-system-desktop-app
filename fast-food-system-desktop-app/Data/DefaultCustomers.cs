using fast_food_system_desktop_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_food_system_desktop_app.Data
{
    public class DefaultCustomers
    {
        //Id = Guid.NewGuid();
        //FirstName = firstName;
        //LastName = lastName;
        //PhoneNumber = phoneNumber;
        //Address = address;
        //Observations = observations;
        //Orders = orders;

        public static HashSet<Customer> customers = new HashSet<Customer>()
        {
            new Customer("Taman", "204-698-4841", "480 Lindsay", null, null),
            new Customer("John Doe", "123-456-7890", "123 Main St, Cityville", new List<string>{ "Allergic to peanuts" }, null),
            new Customer("Jane Smith", "987-654-3210", "456 Oak St, Townsville", new List<string>{ "Prefers spicy food" }, null),
            new Customer("Alice Johnson", "555-123-4567", "789 Pine St, Villageville", new List<string>{ "Vegetarian" }, null),
            new Customer("Bob Brown", "444-987-6543", "321 Maple St, Hamletville", new List<string>{ "Gluten-free" }, null),
            new Customer("Charlie Davis", "333-555-7777", "654 Cedar St, Boroughville", new List<string>{ "Lactose intolerant" }, null)
        };
    }
}
