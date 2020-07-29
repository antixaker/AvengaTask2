using System;
using System.Collections.Generic;

namespace AvengaTestTask2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Visitor { get; set; }
        public IList<Product> Products { get; set; }
    }
}
