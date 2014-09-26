using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _02.AsynchronousTimer
{
    class TimerTester
    {
        public static void SayBau()
        {
            Console.WriteLine("Boooo");
        }

        public static void SayMqu()
        {
            Console.WriteLine("Muuuuuuuuuuuuuu");
        }

        static void Main(string[] args)
        {
            AsyncTimer t1 = new AsyncTimer(20, 100, SayBau);
            AsyncTimer t2 = new AsyncTimer(20, 50, SayMqu);
            t1.run();
            t2.run();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Minkee az ne sa spiram");
                Thread.Sleep(100);
            }
        }
    }
}
