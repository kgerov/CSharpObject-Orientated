using System;
using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    interface ISalesEmployee : IRegularEmployee
    {
        IList<Sale> Sales { get; set; }
    }
}
