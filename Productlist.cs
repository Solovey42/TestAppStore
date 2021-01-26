using System;
using System.Collections.Generic;

#nullable disable

namespace Store
{
    public partial class Productlist
    {
        public int Orderid { get; set; }
        public int Productid { get; set; }
        public int Count { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
