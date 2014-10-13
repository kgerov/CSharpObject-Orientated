using System;

namespace _02.BankOfKurtovoKonare
{
    public class Loan : Account, IDeposit
    {
        public Loan(Customer customer, decimal balance, decimal intRate)
            : base(customer, balance, intRate) { }

        public override decimal CalcInterestRate(int months)
        {
            if ((this.Customer.GetType().Name == "IndividualCustomer" && months <= 3) || 
                (this.Customer.GetType().Name == "CompanyCustomer" && months <= 2))
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
