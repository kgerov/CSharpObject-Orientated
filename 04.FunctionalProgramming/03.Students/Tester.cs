using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Students
{
    class Tester
    {
        static void Main(string[] args)
        {
            Student gosho = new Student("Gosho", "Georgiev", 34, "000014", "+3591341324", "gosho@yahoo.com", new List<int>() { 2, 2, 4, 5 }, 1, "Javari");
            Student pesho = new Student("Pesho", "Zorov", 19, "000113", "+3592341324", "pesho@abv.bg", new List<int>() { 2, 2, 2, 5 }, 2, "Nakovci");
            Student ivanka = new Student("Ivanka", "Abajan", 24, "000214", "+359 2341324", "ivanka@abv.com", new List<int>() { 2, 6, 5 }, 3, "Javari");
            Student ivancho = new Student("Ivancho", "Kovachka", 20, "000313", "021341324", "ivancho@abv.bg", new List<int>() { 6, 2, 2, 5 }, 2, "Javari");
            Student penka = new Student("Penka", "Pechkata", 44, "000414", "02 591341324", "penka@abv.bg", new List<int>() { 6, 2, 6, 6 }, 1, "Nakovci");

            List<Student> SoftUniStudents = new List<Student>() {
                gosho, penka, pesho, ivancho, ivanka
            };

            //Problem 4
            Console.WriteLine("Problem 4.\n");
            var problem4 =
                from st in SoftUniStudents
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;

            foreach (var item in problem4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 140));

            //Problem 5
            Console.WriteLine("Problem 5.\n");
            var problem5 =
                from st in SoftUniStudents
                where st.FirstName.CompareTo(st.LastName) == -1
                select st;

            foreach (var item in problem5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 140));

            //Problem 6
            Console.WriteLine("Problem 6.\n");
            var problem6 =
                from st in SoftUniStudents
                where st.Age >= 18 && st.Age <= 24
                select new {FirstName = st.FirstName, LastName = st.LastName, Age = st.Age };

            foreach (var item in problem6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 140));

            //Problem 7
            Console.WriteLine("Problem 7.\n");

            //SoftUniStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName); //With Lambda

            var problem7 =
                from st in SoftUniStudents
                orderby st.FirstName descending, st.LastName descending
                select st;

            foreach (var item in problem7)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 140));

            //Problem 8
            Console.WriteLine("Problem 8.\n");

            var problem8 =
                from st in SoftUniStudents
                where Regex.IsMatch(st.Email, @"@abv.bg")
                select st;

            foreach (var item in problem8)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 140));

            //Problem 9
            Console.WriteLine("Problem 9.\n");

            var problem9 =
                from st in SoftUniStudents
                where Regex.IsMatch(st.Phone, @"02") || Regex.IsMatch(st.Phone, @"\+3592") || Regex.IsMatch(st.Phone, @"\+359 2")
                select st;

            foreach (var item in problem9)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 140));

            //Problem 10
            Console.WriteLine("Problem 10.\n");

            var problem10 =
                from st in SoftUniStudents
                where st.Marks.IndexOf(6) > -1
                select new { Name = st.FirstName + " " + st.LastName, Marks = st.Marks};
            foreach (var item in problem10)
            {
                Console.WriteLine("Student: {0}, Grades: {1}", item.Name, string.Join(", ", item.Marks));
            }
            Console.WriteLine(new String('-', 140));

            //Problem 11
            Console.WriteLine("Problem 11.\n");

            var problem11 =
                from st in SoftUniStudents
                where st.Marks.ContainsDoubleTwo()
                select new { Name = st.FirstName + " " + st.LastName, Marks = st.Marks };
            foreach (var item in problem11)
            {
                Console.WriteLine("Student: {0}, Grades: {1}", item.Name, string.Join(", ", item.Marks));
            }
            Console.WriteLine(new String('-', 140));

            //Problem 12
            Console.WriteLine("Problem 12.\n");

            SoftUniStudents.Where(x => x.FacultyNumber.Substring(4) == "14").ToList().ForEach(p => Console.WriteLine("{0}, ", p));
            //var problem12 =
            //    from st in SoftUniStudents
            //    where st.FacultyNumber.Substring(4) == "14"
            //    select new { Name = st.FirstName + " " + st.FacultyNumber, Marks = st.Marks };
            //foreach (var item in problem12)
            //{
            //    Console.WriteLine("Student: {0}, Grades: {1}", item.Name, string.Join(", ", item.Marks));
            //}
            Console.WriteLine(new String('-', 140));

            //Problem 13
            Console.WriteLine("Problem 13.\n");

            var problem13 =
                from st in SoftUniStudents
                group (st.FirstName + " " + st.LastName) by st.GroupName into g
                select new { GROUP = g.Key, Students = g.ToList()};
            foreach (var item in problem13)
            {
                Console.WriteLine("Group: {0}\nStudents: {1}\n", item.GROUP, string.Join(", ", item.Students));
            }
            Console.WriteLine(new String('-', 140));

            //Problem 14
            Console.WriteLine("Problem 14.\n");

            StudentSpecialty ivanchoS = new StudentSpecialty("Web Developer", ivancho.FacultyNumber);
            StudentSpecialty goshoS = new StudentSpecialty("PHP Developer", gosho.FacultyNumber);
            StudentSpecialty peshoS = new StudentSpecialty("Java Developer", pesho.FacultyNumber);
            StudentSpecialty ivankaS = new StudentSpecialty("Web Developer", ivanka.FacultyNumber);
            StudentSpecialty penkaS = new StudentSpecialty("PHP Developer", penka.FacultyNumber);

            List<StudentSpecialty> StudentSpecialties = new List<StudentSpecialty>() {
                ivanchoS, penkaS, ivankaS, goshoS, peshoS
            };

            var problem14 =
                from st in SoftUniStudents
                join sp in StudentSpecialties on st.FacultyNumber equals sp.FacultyNumber
                orderby st.FirstName, st.LastName
                select new { Name = st.FirstName + " " + st.LastName, FacNum = st.FacultyNumber, Speciality = sp.SpecialtyName };
            foreach (var item in problem14)
            {
                Console.WriteLine("Name: {0}, Faculty Number: {1}, Speciality: {2}", item.Name, item.FacNum, item.Speciality);
            }
            Console.WriteLine(new String('-', 140));
        }
    }
}
