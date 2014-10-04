using System;

namespace _04.CompanyHierarchy
{
    abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int ID
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("ID must be a positive number");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("ID must be a positive number");
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
                    throw new ArgumentOutOfRangeException("ID must be a positive number");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return String.Format("ID: {0} | Name: {1}", this.id, this.firstName + " " + this.lastName);
        }
    }
}
