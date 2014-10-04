using System;
using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    interface IManager : IEmployee
    {
        List<Employee> Minions { get; set; }
    }
}
