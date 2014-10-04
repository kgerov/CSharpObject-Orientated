using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderExtentions
{
    class Tester
    {
        static void Main(string[] args)
        {
            //Substring Examples
            Console.WriteLine("Substring Examples");
            Console.WriteLine();
            StringBuilder gosho = new StringBuilder("Gosho ne moje da broi do 5");
            Console.WriteLine("Whole string: " + gosho.Substring(0, gosho.Length));
            Console.WriteLine("From index 10 to 14: " + gosho.Substring(10, 5));
            Console.WriteLine("Last char: " + gosho.Substring(gosho.Length-1, 1));
            //Console.WriteLine(gosho.Substring(1, 30)); //THIS WILL THROW AN EXCEPTION
            Console.WriteLine(new String('-', 40));


            //Remove Text Examples
            Console.WriteLine("Remove Examples");
            Console.WriteLine();
            StringBuilder pesho = new StringBuilder("Pesho ne obicha musaka i ne haresva batki");
            Console.WriteLine("Remove 'ne'" + pesho.RemoveText("ne"));
            Console.WriteLine(new String('-', 40));

            //Append Example
            Console.WriteLine("Append Examples");
            Console.WriteLine();
            StringBuilder musaka = new StringBuilder("Musaka raz dva");
            List<int> numbers = new List<int>{
                10, -2, 43, 14, 145, 64
            };
            Console.WriteLine(musaka.AppendAll(numbers));
        }
    }
}
