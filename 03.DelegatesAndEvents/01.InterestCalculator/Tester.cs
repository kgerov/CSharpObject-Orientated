using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.InterestCalculator
{
    class Tester
    {
        public static decimal GetSimpleInterest(double sum, double interest, int years)
        {
            return Convert.ToDecimal(sum * (1 + (interest / 100) * years));
        }

        public static decimal GetCompoundInterest(double sum, double interest, int years)
        {
            return Convert.ToDecimal(sum * Math.Pow((1 + (interest/100) / 12), years * 12));
        }
        static void Main(string[] args)
        {
            InterestCalculator compound = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
            Console.WriteLine(compound);
            InterestCalculator simple = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
            Console.WriteLine(simple);
        }
    }
}
