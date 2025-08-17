using fast_food_system_desktop_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fast_food_system_desktop_app.Data
{
    public class DefaultProductsCategories
    {
        //Id = Guid.NewGuid();
        //ProductId = productId;
        //Product = product;
        //CategoryId = categoryId;
        //Category = category;

        public static void LinkProductsToCategory(HashSet<Product> products, Category category)
        {
            category.ProductCategories ??= new HashSet<ProductCategory>();

            foreach (Product product in products)
            {
                product.ProductCategories ??= new HashSet<ProductCategory>();

                ProductCategory productCategory = new ProductCategory(product.Id, product, category.Id, category);

                product.ProductCategories.Add(productCategory);
                category.ProductCategories.Add(productCategory);
            }
        }
    }
}
