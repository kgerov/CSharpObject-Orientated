using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StudentClass
{
    class Student
    {
        private string name;
        private int age;

        public event PropertyChangedEventHandler PropertyChanged;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Ëmpty name!");
                }
                if (PropertyChanged != null)
                {
                    PropertyChangedEventArgs args = new PropertyChangedEventArgs("Name", this.name, value);
                    PropertyChanged(this, args);
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can't be below 0!");
                }
                if (PropertyChanged != null)
                {
                    PropertyChangedEventArgs args = new PropertyChangedEventArgs("Age", Convert.ToString(this.age), Convert.ToString(value));
                    PropertyChanged(this, args);
                }
                this.age = value;
            }
        }
    }
}
