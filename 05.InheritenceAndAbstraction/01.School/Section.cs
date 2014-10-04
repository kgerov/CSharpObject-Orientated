using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    // Section == Class
    class Section : IDetails
    {
        public string ID { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public string Details { get; set; }

        public Section(string ID, List<Student> students, List<Teacher> teachers, string Details = null)
        {
            this.ID = ID;
            this.Students = students;
            this.Teachers = teachers;
            this.Details = Details;
        } 
    }
}
