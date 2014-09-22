using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.PCCatalog
{
    class Component
    {
        private string name;
        private string details;
        private double price;

        public Component(string name, double price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public Component(string name, double price) : this(name, price, null) { }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Invalid details information");
                }
                else
                {
                    this.details = value;
                }
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (price < 0)
                {
                    throw new ArgumentException("Invalid price");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public override string ToString()
        {
            return this.name + " | " + string.Format("{0:N2}", Math.Truncate(this.price * 100) / 100) + " lv.";
        }
    }
}
