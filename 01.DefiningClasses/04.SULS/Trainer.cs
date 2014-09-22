using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class Trainer : Person
    {
        public Trainer(string name) : base(name) { }
        public Trainer(string name, string lastname) : base(name, lastname) { }

        public Trainer(string name, string lastname, int age) : base(name, lastname, age) { }

        protected static List<string> courses = new List<string>();

        public void CreateCourse(string course)
        {
            if (String.IsNullOrEmpty(course))
            {
                Console.WriteLine("Course Rejected");
            }
            else
            {
                Trainer.courses.Add(course);
                Console.WriteLine("Course Has been created!");
            }
        }

        public static void ViewCourses()
        {
            string allCourses = "List of Courses: ";
            bool placeComma = false;
            foreach (string course in courses)
            {
                if (placeComma)
	            {
                    allCourses += ", ";
	            }
                allCourses += course;
                placeComma = true;
            }
            Console.WriteLine(allCourses);
        }
    }
}
