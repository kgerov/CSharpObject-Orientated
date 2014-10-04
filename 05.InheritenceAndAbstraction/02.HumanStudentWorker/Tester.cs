using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.HumanStudentWorker
{
    class Tester
    {
        static void Main(string[] args)
        {
            // Students
            Student gosho = new Student("Gosho", "Goshhev", "545FF23");
            Student pesho = new Student("Peshp", "Basi", "afd33");
            Student misho = new Student("Misho", "Pahov", "dsaf44");
            Student darcho = new Student("Darcho", "Mahov", "afdj33");
            Student krasi = new Student("Krasii", "Retov", "Fdfa34");
            Student vlado = new Student("Vlado", "Petrov", "958wqF");
            Student ioan = new Student("Ioan", "Mihaelad", "2354FW");
            Student petur = new Student("Petur", "Kichev", "123FF");
            Student vasko = new Student("Vasko", "Slagcho", "asdf433");
            Student prasko = new Student("Prasko", "Bichev", "12fa3FF");

            List<Student> students = new List<Student>() {
                gosho, pesho, misho, darcho, krasi, vlado, ioan, petur, vasko, prasko
            };

            var studentOrder =
                from st in students
                orderby st.FacultyNumber
                select st;

            Console.WriteLine("Ordered Students");
            foreach (var student in studentOrder)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new String('-', 40));

            // Workers
            Worker michael = new Worker("Michael", "Faremhitc", 350m, 6.5m);
            Worker braslov = new Worker("Braslov", "Muucas", 1350m, 3.5m);
            Worker vratko = new Worker("Vratko", "Swadi", 200m, 16.5m);
            Worker krava = new Worker("Krava", "LujiMaji", 150.54m, 6m);
            Worker kuche = new Worker("Kuche", "Maikoo", 570m, 4m);
            Worker kotkov = new Worker("Kotkov", "ZnaeshLiKO", 690m, 12m);
            Worker patkov = new Worker("Patkov", "PisnaMi", 220.43m, 1m);
            Worker traktor = new Worker("Traktor", "HipHopaMi", 124m, 12m);
            Worker kamencho = new Worker("Kamencho", "EMnogoPoDobur", 50m, 4m);
            Worker vreten = new Worker("Vreten", "OtHipHopaTiee", 41440m, 0.5m);

            List<Worker> workers = new List<Worker>() {
                michael, braslov, vratko, krava, kuche, kotkov, patkov, traktor, kamencho, vreten
            };

            var milionercheta =
                from w in workers
                orderby w.MoneyPerHour() descending
                select w;

            Console.WriteLine("Ordered Workers");
            foreach (var worker in milionercheta)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine(new String('-', 40));

            // Students + Workers
            List<Human> people = new List<Human>(students.Count + workers.Count);
            people.AddRange(students);
            people.AddRange(workers);

            var sortPeople =
                from p in people
                orderby p.FirstName, p.LastName
                select p;

            Console.WriteLine("All people sorted");
            foreach (var person in sortPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}
