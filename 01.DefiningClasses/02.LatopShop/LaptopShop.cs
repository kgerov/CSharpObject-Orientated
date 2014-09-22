using System;
using System.Linq;

namespace _02.LatopShop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            Battery bat1 = new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5);
            Battery bat2 = new Battery("Pernishka Sila, 32-cells");

            Laptop lap1 = new Laptop("Lenovo Yoga 2 Pro", 2259, bat1, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display");
            Laptop lap2 = new Laptop("AweComputer", 1.54, ram: "32 GB", bat: bat2);
            Laptop lap3 = new Laptop("DELL Latitude E6540", 2010.5);

            Console.WriteLine(lap1);
            Console.WriteLine(new String('-', 20));
            Console.WriteLine(lap2);
            Console.WriteLine(new String('-', 20));
            Console.WriteLine(lap3);
            Console.WriteLine(new String('-', 20));
        }
    }
}
