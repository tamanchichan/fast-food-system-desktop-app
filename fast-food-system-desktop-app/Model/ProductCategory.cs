using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_food_system_desktop_app.Model
{
    public class ProductCategory
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        //public Product Product { get; set; }

        public Guid CategoryId { get; set; }

        //public Category Category { get; set; }

        public ProductCategory() { }

        public ProductCategory(Guid productId, Guid categoryId)
        {
            Id = Guid.NewGuid();
            ProductId = productId;
            CategoryId = categoryId;
        }
    }
}
