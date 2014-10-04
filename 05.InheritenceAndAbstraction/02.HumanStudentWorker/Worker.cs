using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HumanStudentWorker
{
    class Worker : Human
    {
        public decimal WeekSalary { get; set; }
        public decimal DayWorkTime { get; set; }

        public Worker(string FirstName, string LastName, decimal WeekSalary, decimal DayWorkTime)
            : base(FirstName, LastName)
        {
            this.WeekSalary = WeekSalary;
            this.DayWorkTime = DayWorkTime;
        }

        public decimal MoneyPerHour()
        {
            return Math.Round(this.WeekSalary / 7 / this.DayWorkTime, 2);
        }

        public override string ToString()
        {
            return base.ToString() + ", Money per hour: " + this.MoneyPerHour();
        }
    }
}
