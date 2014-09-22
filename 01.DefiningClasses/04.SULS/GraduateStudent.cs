using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class GraduateStudent : Student
    {
        public GraduateStudent(string name, int studentId, double aveGrade, string lastname = null, int age = 0) : base(name, studentId, aveGrade, lastname, age) { }
    }
}
