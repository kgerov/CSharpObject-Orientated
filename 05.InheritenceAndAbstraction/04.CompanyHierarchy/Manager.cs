using System;
using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    class Manager : Employee, IManager
    {
        private List<Employee> minions;

        public Manager(int id, string firstname, string lastname, decimal salary, Departments department, List<Employee> minions)
            : base(id, firstname, lastname, salary, department)
        {
            this.Minions = minions;
        }

        public List<Employee> Minions
        {
            get { return this.minions; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("List of employees can't be empty");
                }

                this.minions = value;
            }
        }

        public override string ToString()
        {
            string setEm = "";
            bool isFirst = true;
            foreach (var item in this.Minions)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    setEm += ", ";
                }

                setEm += item.FirstName;
            }

            return base.ToString() + String.Format(" | Set of Employees: {0}", setEm);
        }
    }
}
