using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStore.Domain
{
    public class PurchaseOrder
    {
        public long PurchaseOrderId { get; set; }
        public long ProductId { get; set; }
        public long SupplierId { get; set; }
        public DateTime OrderDate { get; set; }
        public int QuantityNeeded { get; set; }

        public Supplier Supplier { get; set; }
        public Product Product { get; set; }
    }
}
