using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number: ");
                int a = Int32.Parse(Console.ReadLine());
                if (a < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine("The square root of {0} is {1}", a, Math.Sqrt(a));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Negative Numbers are not allowed");
            }
            catch(FormatException) 
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
