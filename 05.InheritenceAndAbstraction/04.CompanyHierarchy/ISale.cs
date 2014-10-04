using System;
using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    interface ISale
    {
        string Name { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }
    }
}
