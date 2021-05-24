using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStore.Domain
{
    public class Category
    {
        public Category()
        {
            ProductCategories = new List<ProductCategory>();
        }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        //public virtual ICollection<Product> Products { get; set; }
    }
}
