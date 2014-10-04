using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.School
{
    class Tester
    {
        static void Main(string[] args)
        {
            Student gosho = new Student("Gosho", 203);
            Student pesho = new Student("Pesho", 203, "Pesho e ninja");
            Discipline js = new Discipline("JavaScript", 56, new List<Student>() {gosho, pesho});
            Discipline kpk = new Discipline("Kachestven Programen Kod", 40, new List<Student>() {gosho}, "Qkata rabota");
            Teacher ginka = new Teacher("Ginka", new List<Discipline>() { js, kpk});
            Teacher penka = new Teacher("Penka", new List<Discipline>() { js });

            Section class203 = new Section("Ultra Ninjite", new List<Student>() { pesho, gosho }, new List<Teacher>() { ginka, penka });
        }
    }
}
