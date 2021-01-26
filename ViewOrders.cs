using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public partial class ViewOrder
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public float Cost { get; set; }
        public DateTime Date { get; set; }
    }
}
