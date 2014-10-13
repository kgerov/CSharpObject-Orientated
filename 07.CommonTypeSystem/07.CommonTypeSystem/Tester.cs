using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CommonTypeSystem
{
    class Tester
    {
        static void Main(string[] args)
        {
            Payment payments1 = new Payment("Pechka 2000", 5430m);

            Customer gosho = new Customer("Gosho", "Petkov", "Goshev", "7534571123", "Det se vika street 1", "+23423534", "goshetobe@abv.bg", new List<Payment>() {payments1 }, CustomerType.Diamond);
            Customer pesho = new Customer("Pesho", "Simeonov", "Vratsev", "8134573122", "Det se vika street 2", "+543252345", "pesho@abv.bg", new List<Payment>() { payments1 }, CustomerType.Golden);
            Customer ivancho = new Customer("Ivancho", "Koshev", "Noslachas", "2456788523", "Det se vika street 4", "+1235543", "ivancho@abv.bg", new List<Payment>() { payments1 }, CustomerType.Regular);
            Customer gosho2 = new Customer("Gosho", "Translav", "Goshev", "3456788523", "Det se vika street 6", "+24234234", "gosho@abv.bg", new List<Payment>() { payments1 }, CustomerType.Regular);

            if (gosho == gosho2)
            {
                Console.WriteLine("Gosho is equal to Gosho2");
            }

            if (gosho != pesho)
            {
                Console.WriteLine("Gosho is not equal to Pesho");
            }

            Console.WriteLine("\n\n");

            //ICloneable

            Customer gg = gosho;
            if (gg == gosho)
            {
                gg.MiddleName = "Bravos";
                Console.WriteLine(gosho.MiddleName);
                Console.WriteLine("Same object!");
            }

            Customer angel = gosho.Clone() as Customer;
            angel.FirstName = "Gencho";
            if (angel == gosho)
            {
                Console.WriteLine("Same object!");
            }
            else
            {
                Console.WriteLine("Different Object");
            }

            Console.WriteLine("\n\n");

            //ICOMPARABLE

            Customer[] customers = new Customer[] {
                gosho, pesho, ivancho, gosho2, angel
            };

            Array.Sort(customers);

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
