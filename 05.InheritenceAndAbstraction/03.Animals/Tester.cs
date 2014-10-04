using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Animals
{
    class Tester
    {
        static void Main(string[] args)
        {
            Dog sharo = new Dog("Sharo", 12, "Male");
            Dog laika = new Dog("Laika", 20, "Female");
            Cat maci = new Cat("Maci", 5, "male");
            Cat cezar = new Cat("Cezar", 2, "male");
            Frog niki = new Frog("Niki", 4, "male");
            Kitten qia = new Kitten("Qia", 1);
            Kitten misha = new Kitten("Misho", 2);
            Tomcat gosho = new Tomcat("Gosho", 4);

            List<Animal> zoo = new List<Animal>() {
                sharo, laika, maci, cezar, niki, qia, misha, gosho
            };

            sharo.ProduceSound();
            qia.ProduceSound();
            niki.ProduceSound();

            var groupedZoo =
                from a in zoo
                group a by a.GetType().Name into g
                select new { GROUP = g.Key, AVAGE = g.Average(x => x.Age) };

            foreach (var animal in groupedZoo)
            {
                Console.WriteLine("Average age of {0} is {1}", animal.GROUP, animal.AVAGE);
            }
        }
    }
}
