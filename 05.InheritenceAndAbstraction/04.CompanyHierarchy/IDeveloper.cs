using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy
{
    interface IDeveloper : IRegularEmployee
    {
        IList<IProject> Projects { get; set; }
    }
}
