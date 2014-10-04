using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Students
{
    class StudentSpecialty
    {
        public string SpecialtyName { get; set; }

        public string FacultyNumber { get; set; }

        public StudentSpecialty(string SpecialtyName, string FacultyNumber)
        {
            this.SpecialtyName = SpecialtyName;
            this.FacultyNumber = FacultyNumber;
        }
    }
}
