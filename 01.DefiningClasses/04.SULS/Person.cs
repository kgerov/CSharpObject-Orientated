using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class Person
    {
        private string name;
        private string lastname;
        private int age;

        public Person(string name, string lastname, int age)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
        }

        public Person(string name) : this(name, null, 0) { }

        public Person(string name, string lastname) : this(name, lastname, 0) { }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Name");
                }
                this.name = value;
            }
        }

        public string Lastname
        {
            get { return this.lastname; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Invalid Last name");
                }
                this.lastname = value;
            }
        }

        public int Age 
        {
            get { return this.age; }
            set
            {
                if (age < 0)
                {
                    throw new ArgumentException("Invalid Age");
                }
                this.age = value;
            }
        }
    }
}
