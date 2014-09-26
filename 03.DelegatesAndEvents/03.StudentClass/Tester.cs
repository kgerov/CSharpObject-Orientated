using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StudentClass
{
    class Tester
    {
        static void Main(string[] args)
        {
            Student Pesho = new Student("Pesho", 25);
            Pesho.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropName, eventArgs.OldValue, eventArgs.NewValue);
            };
            Pesho.Name = "Maria";
            Pesho.Age = 19;
        }
    }
}
