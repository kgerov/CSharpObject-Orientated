using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string name) : base(name) { }
        public SeniorTrainer(string name, string lastname) : base(name, lastname) { }
        public SeniorTrainer(string name, string lastname, int age) : base(name, lastname, age) { }

        public void RemoveCourse(string course)
        {
            bool flag = true;
            foreach (string c in courses)
            {
                if (c == course)
                {
                    courses.Remove(c);
                    Console.WriteLine("Successfuly Removed");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("No such item");
                
            }
        }
    }
}
