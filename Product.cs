using System;
using System.Collections.Generic;

#nullable disable

namespace Store
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public float? Cost { get; set; }
        public string Info { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
