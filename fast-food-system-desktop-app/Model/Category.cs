using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_food_system_desktop_app.Model
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public HashSet<ProductCategory>? ProductCategories { get; set; } = new HashSet<ProductCategory>();

        public Category() { }

        public Category(string name, HashSet<ProductCategory>? productCategories)
        {
            Id = Guid.NewGuid();
            Name = name;
            ProductCategories = productCategories;
        }
    }
}
