using System;

namespace _02.BankOfKurtovoKonare
{
    public class Mortage : Account, IDeposit
    {
        public Mortage(Customer customer, decimal balance, decimal intRate)
            : base(customer, balance, intRate) { }

        public override decimal CalcInterestRate(int months)
        {
            if (this.Customer.GetType().Name == "CompanyCustomer" && months <= 12)
            {
                return (base.CalcInterestRate(months) / 2.0m);
            }

            if (this.Customer.GetType().Name == "IndividualCustomer" && months <= 6)
            {
                return this.Balance;
            }

            return base.CalcInterestRate(months);
        }
        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
