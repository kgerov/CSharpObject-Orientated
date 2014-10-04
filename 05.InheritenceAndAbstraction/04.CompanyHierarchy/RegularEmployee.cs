using System;
using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    abstract class RegularEmployee  : Employee, IRegularEmployee
    {
        public RegularEmployee(int id, string firstname, string lastname, decimal salary, Departments department)
            : base(id, firstname, lastname, salary, department) { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
