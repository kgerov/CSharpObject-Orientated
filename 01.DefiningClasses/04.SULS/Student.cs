using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class Student : Person
    {
        protected int studentId;
        protected double aveGrade;

        public Student(string name, int studentId, double aveGrade, string lastname = null, int age = 0)
            : base(name, lastname, age)
        {
            this.StudentId = studentId;
            this.AveGrade = aveGrade;
        }


        public int StudentId 
        {
            get { return this.studentId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalud Student ID");
                }
                this.studentId = value;
            } 
            
        }

        public double AveGrade
        {
            get { return this.aveGrade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalud Average Grade ID");
                }
                this.aveGrade = value;
            }

        }
    }
}
