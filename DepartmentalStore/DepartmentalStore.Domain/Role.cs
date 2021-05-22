using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStore.Domain
{
    public class Role
    {
        public long Id { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
       // public ICollection<Staff> Staff {​​​​​ get; set; }​​​​​
       public ICollection<Staff> Staff { get; set; }
    }
}
