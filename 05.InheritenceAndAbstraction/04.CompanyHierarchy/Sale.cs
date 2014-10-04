using System;
using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    class Sale : ISale
    {
        private string name;
        private DateTime date;
        private decimal price;

        public Sale(string name, decimal price)
            : this(name, default(DateTime), price) { }

        public Sale(string name, DateTime date, decimal price)
        {
            this.Name = name;
            this.Date = date;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("String Can't be null or empty");
                }

                this.name = value;
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price can't be negative");
                }

                this.price = value;
            }
        }
    }
}
