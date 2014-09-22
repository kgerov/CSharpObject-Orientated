using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class Program
    {
        public static void ReadNumber(int start, int end)
        {
            Console.Write("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());
            if (n < start || n > end)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            bool tryAgain = false;
            Console.WriteLine("Enter 10 integers in range [{0}...{1}]: ", start, end);
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    ReadNumber(start, end);
                    tryAgain = false;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("NUMBER OUT OF RANGE!");
                    tryAgain = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                    tryAgain = true;
                }
                if (tryAgain)
                {
                    Console.WriteLine("Try again...");
                    i--;
                }
            }
        }
    }
}
