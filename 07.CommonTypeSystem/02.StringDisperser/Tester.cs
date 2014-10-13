using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringDisperser
{
    class Tester
    {
        static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            StringDisperser sD2 = new StringDisperser("gosho", "pesho", "tanio");

            // Equals
            Console.WriteLine(stringDisperser == sD2);
            Console.WriteLine();

            // Clone
            StringDisperser cloneTest = sD2;
            cloneTest.Parts = new String[] { "vla", "bla" };
            Console.WriteLine(sD2);

            sD2.Parts = new String[] { "gosho", "pesho", "tanio" };
            StringDisperser trueClone = sD2.Clone() as StringDisperser;
            trueClone.Parts = new String[] { "lqlql", "bla" };
            Console.WriteLine(sD2);
            Console.WriteLine();

            // Compare to
            if (sD2.CompareTo(trueClone) < 0)
            {
                Console.WriteLine("Smaller");
            }

            Console.WriteLine();

            // IEnumerator
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();
        }
    }
}
