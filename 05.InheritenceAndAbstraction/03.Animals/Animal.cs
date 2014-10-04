using System;

namespace _03.Animals
{
    abstract class Animal : ISound
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender; 
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't be empty or null");
                }

                this.name = value;
            }
        }

        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Gender can't be empty or null");
                }

                this.gender = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (age < 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be positive!");
                }

                this.age = value;
            }
        }

        public abstract void ProduceSound();
    }
}
