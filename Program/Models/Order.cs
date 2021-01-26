using System;
using System.Collections.Generic;

#nullable disable

namespace Store
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? Clientid { get; set; }
        public int? Productid { get; set; }
        public DateTime? Date { get; set; }

        public virtual Client Client { get; set; }

        public virtual Product Product { get; set; }
    }
}
