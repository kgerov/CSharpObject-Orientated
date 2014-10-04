using System;

namespace _04.CompanyHierarchy
{
    interface IEmployee : IPerson
    {
        decimal Salary { get; set; }
        Departments Department { get; set; }
    }
}
