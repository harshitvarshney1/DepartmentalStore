using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStore.Domain
{
    public class ProductCategory
    {
        public long ProductId { get; set; }
        public long CategoryId { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }

    }
}
