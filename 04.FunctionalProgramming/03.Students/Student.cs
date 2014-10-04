using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Students
{
    //THIS CLASS DOESN'T FOLLOW THE BEST PRACTISES FOR OOP BECAUSE THE PURPOSE OF THIS HOMEWORK IS TO WORK WITH LINQ
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public string GroupName { get; set; }

        public Student(string FristName, string LastName, int age, string FacultyNumber, string Phone, string Email, List<int> Marks, int GroupNumber, string GroupName)
        {
            this.FirstName = FristName;
            this.LastName = LastName;
            this.Age = age;
            this.FacultyNumber = FacultyNumber;
            this.Phone = Phone;
            this.Email = Email;
            this.Marks = Marks;
            this.GroupNumber = GroupNumber;
            this.GroupName = GroupName;
        }

        public override string ToString()
        {
            string marks = "";
            foreach (var item in this.Marks)
            {
                if (this.Marks.IndexOf(item) != 0)
                {
                    marks += ", ";
                }
                marks += Convert.ToString(item);
            }
            return String.Format("First Name: {0}, Last Name: {1}, Age: {2}, Faculty Number: {3}, Phone: {4}, Email: {5}, Marks: {6}, Group Number: {7}, Group Name: {8}", this.FirstName, this.LastName, this.Age, this.FacultyNumber, this.Phone, this.Email, marks, this.GroupNumber, this.GroupName);
        }
    }
}
