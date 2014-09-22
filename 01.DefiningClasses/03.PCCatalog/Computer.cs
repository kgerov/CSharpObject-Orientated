using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.PCCatalog
{
    class Computer
    {
        private string name;
        private double price = 0;
        private List<Component> components = new List<Component>();

        public Computer(string name, List<Component> comp)
        {
            this.Name = name;
            this.Component = comp;
            if (comp != null)
            {
                foreach (Component item in comp)
                {
                    price += item.Price;
                }    
            }
        }

        public Computer(string name) : this(name, null) { }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Name");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public double Price
        {
            get { return this.price; }
            private set { }
        }

        public List<Component> Component
        {
            get { return this.components;  }
            set
            {
                this.components = value;
            }
        }

        public void Info()
        {
            Console.WriteLine("Computer name: " + this.name);
            if (components != null && components.Count() > 0)
            {
                Console.Write("Components: ");
                foreach (var item in this.components)
                {
                    Console.Write(item.ToString() + "; ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Price: " + this.price + " lv.");
        }
    }
}
