using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Teacher : Person, IDetails
    {
        public List<Discipline> Disciplines { get; set; }
        public string Details { get; set; }

        public Teacher(string name, List<Discipline> disciplines, string Details = null)
            : base(name)
        {
            this.Disciplines = disciplines;
            this.Details = Details;
        }
    }
}
