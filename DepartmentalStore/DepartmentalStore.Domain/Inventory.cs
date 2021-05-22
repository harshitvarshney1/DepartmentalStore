using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStore.Domain
{
    public class Inventory
    {
        public long InventoryId { get; set; }
        public long ProductId { get; set; }
        public bool InStock { get; set; }
        public int ProductQuantity { get; set; }
        public Product Product { get; set; }
    }
}
