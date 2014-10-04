using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.LinqToExcel
{
    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string StudentType { get; set; }
        public int ExamResult { get; set; }
        public int HWSent { get; set; }
        public int HWEvaluated { get; set; }
        public double Teamwork { get; set; }
        public int Attendances { get; set; }
        public double Bonus { get; set; }
        public double Result { get; set; }

        public Student(int id, string fname, string lname, string email, string gender, string studenttype, int exam, int hwsent, int hweval, double teamwork, int attendance, double bonus)
        {
            this.ID = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.Email = email;
            this.Gender = gender;
            this.StudentType = studenttype;
            this.ExamResult = exam;
            this.HWSent = hwsent;
            this.HWEvaluated = hweval;
            this.Teamwork = teamwork;
            this.Attendances = attendance;
            this.Bonus = bonus;
            this.Result = CalcResult();
        }

        private double CalcResult()
        {
            return (this.ExamResult + this.HWSent + this.HWEvaluated + this.Teamwork + this.Attendances + this.Bonus) / 5.0;
        }

    }
}
