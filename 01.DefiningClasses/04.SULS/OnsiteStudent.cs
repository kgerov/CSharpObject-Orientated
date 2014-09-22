using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class OnsiteStudent : CurrentStudent
    {
        private int visits;
        public OnsiteStudent(string name, int studentId, double aveGrade, string currentCourse, int visits, string lastname = null, int age = 0)
            : base(name, studentId, aveGrade, currentCourse, lastname, age)
        {
            this.Visits = visits;
        }

        public int Visits 
        {
            get { return this.visits; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Number of Visits");
                }
                this.visits = value;
            }
        }
    }
}
