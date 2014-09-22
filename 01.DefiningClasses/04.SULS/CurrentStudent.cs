using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class CurrentStudent : Student
    {
        protected string currentCourse;

        public CurrentStudent(string name, int studentId, double aveGrade, string currentCourse, string lastname = null, int age = 0)
            : base(name, studentId, aveGrade, lastname, age)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get { return this.currentCourse; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Course Name");
                }
                this.currentCourse = value;
            }
        }
    }
}
