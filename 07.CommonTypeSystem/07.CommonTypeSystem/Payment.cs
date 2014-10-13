using System;
using System.Collections.Generic;

namespace _07.CommonTypeSystem
{
    public class Payment
    {
        public Payment(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
