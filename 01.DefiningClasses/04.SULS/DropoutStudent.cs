using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class DropoutStudent : Student
    {
        private string dropReason;

        public DropoutStudent(string name, int studentId, double aveGrade, string dropReason, string lastname = null, int age = 0)
            : base(name, studentId, aveGrade, lastname, age)
        {
            this.DropReason = dropReason;
        }

        public string DropReason 
        {
            get { return this.dropReason; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Ivalid Dropout Reason");
                }
                this.dropReason = value;
            }
        }

        public void Reapply()
        {
            string res = "First Name: " + this.Name + "\nStudent ID: " + this.StudentId + "\nAverage Grade: " + this.AveGrade + "\nDrop out Reason: " + DropReason;
            if (this.Lastname != null)
            {
                res += "\nLastname: " + this.Lastname;
            }
            if (this.Age != 0)
            {
                res += "\nAge: " + this.Age;
            }

            Console.WriteLine(res);
        }
    }
}
