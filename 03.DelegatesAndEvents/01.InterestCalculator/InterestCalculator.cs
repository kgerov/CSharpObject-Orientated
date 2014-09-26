using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.InterestCalculator
{
    public delegate decimal getInterest(double moneySum, double interestRate, int years);
    class InterestCalculator
    {
        private double moneySum;
        private double interestRate;
        private int years;
        private decimal interest;

        public InterestCalculator(double moneySum, double interestRate, int years, getInterest getInt)
        {
            this.moneySum = moneySum;
            this.interestRate = interestRate;
            this.years = years;
            getInterest gt = new getInterest(getInt);
            this.interest = gt(moneySum, interestRate, years);
        }

        public override string ToString()
        {
            return String.Format("Money: {0}; Interest Rate: {1}; Years: {2}; Result: {3 : 0.0000}", this.moneySum, this.interestRate, this.years, this.interest);
        }
    }
}
