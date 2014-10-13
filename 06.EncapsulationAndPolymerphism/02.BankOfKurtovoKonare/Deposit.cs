using System;

namespace _02.BankOfKurtovoKonare
{
    public class Deposit : Account, IDeposit, IWithdraw
    {
        public Deposit(Customer customer, decimal balance, decimal intRate)
            : base(customer, balance, intRate) { }
     
        public override decimal CalcInterestRate(int months)
        {
            if (this.Balance >= 0 && this.Balance <= 1000)
            {
                return this.Balance;
            }
            else
            {
                return base.CalcInterestRate(months);
            }
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
