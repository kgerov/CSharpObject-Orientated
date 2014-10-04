using System;

namespace _02.HumanStudentWorker
{
    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}", (this.FirstName + " " + this.LastName));
        }
    }
}
