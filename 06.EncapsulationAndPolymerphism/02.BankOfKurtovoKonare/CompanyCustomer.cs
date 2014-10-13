using System;

namespace _02.BankOfKurtovoKonare
{
    public class CompanyCustomer : Customer
    {
        private string name;

        public CompanyCustomer(string name)
        {

        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't be null/empty");
                }

                this.name = value;
            }
        }
    }
}
