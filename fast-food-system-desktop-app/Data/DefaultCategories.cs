using fast_food_system_desktop_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_food_system_desktop_app.Data
{
    public class DefaultCategories
    {
        //Id = Guid.NewGuid();
        //Name = name;
        //ProductCategories = productCategories;

        public static Category appetizer = new Category("Appetizer", null);

        public static Category mixedGreens = new Category("Mixed Greens", null);

        public static HashSet<Category> categories = new HashSet<Category>()
        {
            appetizer,
            mixedGreens
        };
    }
}
