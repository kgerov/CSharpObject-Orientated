using System;
using System.Linq;

namespace _02.LatopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private double price;
        private Battery bat;

        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, double price, Battery bat = default(Battery), string manufacturer = null, string processor = null, string ram = null, string graphicsCard = null, string hdd = null, string screen = null)
            : this(model, price)
        {
            this.Battery = bat;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
        }

        public string Model 
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model Name is invalid");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Price");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Model Name is invalid");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Processor is invalid");
                }
                else
                {
                    this.processor = value;
                }
            }
        }

        public string RAM
        {
            get { return this.ram; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("RAM is invalid");
                }
                else
                {
                    this.ram = value;
                }
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Graphics Card is invalid");
                }
                else
                {
                    this.graphicsCard = value;
                }
            }
        }

        public string HDD
        {
            get { return this.hdd; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("HDD is invalid");
                }
                else
                {
                    this.hdd = value;
                }
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Screen is invalid");
                }
                else
                {
                    this.screen = value;
                }
            }
        }

        public Battery Battery
        {
            get { return this.bat; }
            set { this.bat = value; }
        }

        public override string ToString() 
        {
            string result = "Laptop model: " + this.model + "\nPrice: " + string.Format("{0:N2}", Math.Truncate(this.price * 100) / 100) + " lv.";
            if (!String.IsNullOrEmpty(this.manufacturer))
	        {
                result += "\nManufacturer: " + this.manufacturer;
	        }
            if (!String.IsNullOrEmpty(this.processor))
            {
                result += "\nProcessor: " + this.processor;
            }
            if (!String.IsNullOrEmpty(this.ram))
            {
                result += "\nRam: " + this.ram;
            }
            if (!String.IsNullOrEmpty(this.graphicsCard))
            {
                result += "\nGraphics Card: " + this.graphicsCard;
            }
            if (!String.IsNullOrEmpty(this.hdd))
            {
                result += "\nHDD: " + this.hdd;
            }
            if (!String.IsNullOrEmpty(this.screen))
            {
                result += "\nScreen: " + this.screen;
            }
            if (this.bat != null)
            {
                result += "\nBattery: " + this.bat;
            }
            return result;
        }
    }
}
