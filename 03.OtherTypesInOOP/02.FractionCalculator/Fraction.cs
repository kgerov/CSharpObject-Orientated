using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FractionCalculator
{
    struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long num, long den)
            : this()
        {
            long gcd = GCD(num, den);
            this.Numerator = num / gcd;
            this.Denominator = den / gcd;
        }
        private static long GCD(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                a = a % b;
                if (a == 0) { break; }
                b = b % a;
            }

            return (a == 0 ? b : a);
        }

        public long Numerator 
        {
            get { return this.numerator; }
            set { this.numerator = value; }
        }

        public long Denominator
        {
            get { return this.denominator; }
            set 
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator can't be zero");
                }
                this.denominator = value; 
            }
        }


        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long numerator = f1.Numerator * f2.Denominator + f1.Denominator * f2.Numerator;
            long denominator = f1.Denominator * f2.Denominator;

            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long numerator = f1.Numerator * f2.Denominator - f1.Denominator * f2.Numerator;
            long denominator = f1.Denominator * f2.Denominator;

            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return Convert.ToString((decimal)this.numerator / this.denominator);
        }
    }
}
