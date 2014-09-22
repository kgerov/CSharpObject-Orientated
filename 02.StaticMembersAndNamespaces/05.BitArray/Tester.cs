using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitArray
{
    class Tester
    {
        static void Main(string[] args)
        {
            BitArray t = new BitArray(100000);

            t[99999] = 1;
            t[5432] = 1;

            for (int i = 0; i < 100000; i++)
            {
                t[i] = 1;
            }
            Console.WriteLine(t);
        }
    }
}
