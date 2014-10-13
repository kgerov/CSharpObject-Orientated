using System;

namespace _02.BankOfKurtovoKonare
{
    public class IndividualCustomer : Customer
    {
        private string firstName;
        private string lastName;

        public IndividualCustomer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName 
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First Name can't be null/empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last Name can't be null/empty");
                }

                this.lastName = value;
            }
        }
    }
}
