using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CustomLinq
{
    class Tester
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() {
                1, 2, 3, 4, 5
            };

            var whereNot = list1.WhereNot(x => x > 3);

            foreach (var item in whereNot)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new String('-', 40));

            foreach (var item in list1.Repeat(3))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new String('-', 40));

            List<string> text = new List<string>() {
                "az", "braz", "paz", "car", "tar", "zz", "asd", "abc" 
            };

            List<string> suff = new List<string>() {
                "az", "ar"
            };

            foreach (var item in text.WhereEndsWith(suff))
            {
                Console.WriteLine(item);
            }
        }
    }
}
