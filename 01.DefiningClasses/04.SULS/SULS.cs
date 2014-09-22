using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class SULS
    {
        static void Main(string[] args)
        {
            //Normal Person
            Person normalGosho = new Person("Gosho", "Batka", 15);

            //Trainer
            Trainer Pesho = new Trainer("Pesho", "Ganev", 34);
            Pesho.CreateCourse("C# Fundamentals");
            Pesho.CreateCourse("");
            Pesho.CreateCourse("Java Basics");
            Pesho.CreateCourse("PHP");
            Trainer.ViewCourses();
            Console.WriteLine(new String('-', 40));

            //Senior Trainer
            SeniorTrainer Nakov = new SeniorTrainer("Svetlin", "Nakov");
            Nakov.CreateCourse("Ninja Programmer");
            SeniorTrainer.ViewCourses();
            Nakov.RemoveCourse("Java Basics");
            Nakov.RemoveCourse("DrunDrun");
            Trainer.ViewCourses();
            Console.WriteLine(new String('-', 40));

            //Junior Trainer
            JuniorTrainer Penka = new JuniorTrainer("Penka");

            //Student
            Student Borcho = new Student("Borcho", 5189154, 5.5, "Penchev", 54);

            //Graduate Student
            GraduateStudent Dimitri = new GraduateStudent("Dimitri", 132623453, 4.3);

            //Current Student
            CurrentStudent Bachi = new CurrentStudent("Bachi", 623454235, 3.4, "Math Algorithms");

            //Droput Student 
            DropoutStudent Ivancho = new DropoutStudent("Ivancho", 412341, 2.0, "I can't learn regex expressions");
            Ivancho.Reapply();
            Console.WriteLine(new String('-', 40));

            //Online Student
            OnlineStudent Qwerty = new OnlineStudent("Qwerty", 273485, 4.5, "PHP");

            //Onsite Student
            OnsiteStudent Gencho = new OnsiteStudent("Gencho", 513451, 6.0, "Java", 84);
            OnsiteStudent Mariika = new OnsiteStudent("Mariika", 45634653, 5.9, "JavaScript", 34, "Pencheva", 45);

            List<Person> people = new List<Person>()
	        {
	            Bachi,
                Gencho,
                Mariika,
                Qwerty,
                Penka,
                Borcho,
                Dimitri, 
                Ivancho,
                normalGosho,
                Nakov
	        };

            people.Where(x => x.GetType().BaseType.Name == "CurrentStudent").OrderByDescending(x => ((Student)x).AveGrade).ToList().ForEach(x => Console.WriteLine(x.Name + " -> " + ((Student)x).AveGrade));

        }
    }
}
