using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Discipline : IDetails
    {
        public string Name { get; set; }
        public int LecturesCount { get; set; }
        public List<Student> Studets { get; set; }
        public string Details { get; set; }

        public Discipline(string name, int lecturesCount, List<Student> students, string Details = null)
        {
            this.Name = name;
            this.LecturesCount = lecturesCount;
            this.Studets = students;
            this.Details = Details;
        }
    }
}
