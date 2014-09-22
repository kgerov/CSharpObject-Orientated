using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.PCCatalog
{
    class PCCatalog
    {
        static void Main(string[] args)
        {
            Component processor = new Component("Processor", 200, "Batka Procesor");
            Component graphicsCard = new Component("Graphics Card", 350);
            Component motherboard = new Component("Motherboard", 500);
            Component ram = new Component("RAM", 1000);
            
            List<Component> parts = new List<Component>();
            parts.Add(processor);
            parts.Add(graphicsCard);
            parts.Add(motherboard);

            Computer comp1 = new Computer("DELL", parts);
            comp1.Info();
            Console.WriteLine(new String('-', 40));
            Computer comp2 = new Computer("HP");
            comp2.Info();
            Console.WriteLine(new String('-', 40));
            parts.Add(ram);
            Computer comp3 = new Computer("Macbook", parts);
            comp3.Info();
            Console.WriteLine(new String('-', 40));
            parts.Remove(graphicsCard);
            Computer comp4 = new Computer("Banicabook", parts);
            comp4.Info();
            Console.WriteLine(new String('-', 40));

            List<Computer> computerStore = new List<Computer>();
            computerStore.Add(comp1);
            computerStore.Add(comp2);
            computerStore.Add(comp3);
            computerStore.Add(comp4);
            computerStore.Sort(delegate(Computer c1, Computer c2) { return c1.Price.CompareTo(c2.Price); });

            Console.WriteLine("Sorted");
            foreach (Computer comp in computerStore)
            {
                Console.WriteLine(comp.Name + " | " + comp.Price + " lv.");
            }
        }
    }
}
