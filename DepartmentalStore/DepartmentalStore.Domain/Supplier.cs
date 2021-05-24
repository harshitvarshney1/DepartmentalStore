using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStore.Domain
{
    public class Supplier
    {
        public Supplier()
        {
            SupplierProducts = new List<SupplierProduct>();
        }
        public long SupplierId  { get; set; }
        public string SupplierName { get; set; }
        public string PhoneNumber{ get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public List<SupplierProduct> SupplierProducts { get; set; }
      //  public PurchaseOrder PurchaseOrder { get; set; }
    }
}
