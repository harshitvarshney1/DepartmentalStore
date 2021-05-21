using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStore.Domain
{
    public class Product {
        public Product()
        {
            ProductCategories = new List<ProductCategory>();
            SupplierProducts = new List<SupplierProduct>();
        }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public string ShortCode { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        // public virtual ICollection<Category> Categories { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<SupplierProduct> SupplierProducts { get; set; }
    }
}
