using System;

namespace _04.CompanyHierarchy
{
    abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Departments department;

        public Employee(int id, string firstname, string lastname, decimal salary, Departments department)
            : base(id, firstname, lastname)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary must be a positive number");
                }

                this.salary = value;
            }
        }

        public Departments Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" | Salary: {0} | Department: {1}", this.salary, this.department);
        }
    }
}
