using System;

namespace _02.BankOfKurtovoKonare
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal intRate;

        public Account(Customer customer, decimal balance, decimal intRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.IntRate = intRate;
        }

        public Customer Customer { get; set; }
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal IntRate
        {
            get { return this.intRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest Rate can't be zero");
                }

                this.intRate = value;
            }
        }

        public virtual decimal CalcInterestRate(int months)
        {
            return this.Balance * (1 + this.IntRate * months);
        }
    }
}