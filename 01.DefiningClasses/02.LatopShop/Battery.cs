using System;
using System.Linq;

namespace _02.LatopShop
{
    class Battery
    {
        private string type;
        private double lifespan;

        public Battery(string type, double lifespan)
        {
            this.Lifespan = lifespan;
            this.type = type;
        }

        public Battery(string type) : this(type, 0) {}

        public Battery() : this(null, 0) { }

        public double Lifespan 
        {
            get { return this.lifespan; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery Life Can't be negative");
                }
                else
                {
                    this.lifespan = value;
                }
            } 
        }

        public string Type
        {
            get { return this.type; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Invalid Battery Name!");
                }
                else
                {
                    this.type = value;
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            if (!String.IsNullOrEmpty(this.type))
            {
                result += "Battery type: " + this.type;
            }
            if (this.lifespan > 0)
            {
                result += "; Battery Life: " + this.lifespan;
            }

            return result;
        }
    }
}
