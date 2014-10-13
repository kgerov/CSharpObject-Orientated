using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BankOfKurtovoKonare
{
    class Tester
    {
        static void Main()
        {
            CompanyCustomer Microsoft = new CompanyCustomer("Microsoft");
            IndividualCustomer BateGosho = new IndividualCustomer("Gosho", "Petrov");

            Deposit goshoDeposit = new Deposit(BateGosho, 160.0m, 0.01m);

            Loan msLoan = new Loan(Microsoft, 100000m, 0.1m);
            Loan goshoLoan = new Loan(BateGosho, 300m, 0.06m);

            Mortage msMortage = new Mortage(Microsoft, 10000m, 0.5m);
            Mortage goshoMortage = new Mortage(BateGosho, 230m, 0.05m);

            Console.WriteLine("Mortage before deposit of 50 leva: {0}", goshoMortage.Balance);
            goshoMortage.DepositMoney(50m);
            Console.WriteLine("Mortage after deposit of 50 leva: {0}", goshoMortage.Balance);
            Console.WriteLine("\n\n");

            Console.WriteLine("Deposit before withdraw of 150 leva: {0}", goshoDeposit.Balance);
            goshoDeposit.Withdraw(150m);
            Console.WriteLine("Deposit after withdraw of 150 leva: {0}", goshoDeposit.Balance);
            Console.WriteLine("\n\n");

            Console.WriteLine("Balance after interest rate for deposit of 10 leva for 3 months: {0}", goshoDeposit.CalcInterestRate(3));
            goshoDeposit.DepositMoney(1090m);
            Console.WriteLine("Balance after interest rate for deposit of 1100 leva for 3 months: {0}", goshoDeposit.CalcInterestRate(3));
            Console.WriteLine("\n");

            Console.WriteLine("Balance after interest rate for loan of Individual for 2 months: {0}", goshoLoan.CalcInterestRate(2));
            Console.WriteLine("Balance after interest rate for loan of Company for 3 months: {0}", msLoan.CalcInterestRate(3));
            Console.WriteLine("Balance after interest rate for mortage of Individual for 5 months: {0}", goshoMortage.CalcInterestRate(5));
            Console.WriteLine("Balance after interest rate for mortage of Company for 11 months: {0}", msMortage.CalcInterestRate(11));
        }
    }
}
