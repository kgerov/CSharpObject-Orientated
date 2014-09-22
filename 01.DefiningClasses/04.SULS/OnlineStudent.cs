using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string name, int studentId, double aveGrade, string currentCourse, string lastname = null, int age = 0) : base(name, studentId, aveGrade, currentCourse, lastname, age) { }
    }
}
