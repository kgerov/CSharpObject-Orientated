using System;
using System.Text.RegularExpressions;

namespace _02.HumanStudentWorker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string FirstName, string LastName, string FacultyNumber)
            : base(FirstName, LastName)
        {
            this.FacultyNumber = FacultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (!Regex.IsMatch(value, @"\b[0-9A-Za-z]{5,10}\b"))
                {
                    throw new ArgumentException("Faculty Number must contain between 5 and 10 letters and/or numbers!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, Faculty Number: {1}", base.ToString(), this.FacultyNumber);
        }
    }
}
