using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CompanyHierarchy
{
    interface IProject
    {
        string Name { get; set; }
        DateTime StartDate { get; set; }
        string Details { get; set; }
        bool IsActive { get; set; }
        void CloseProject();
    }
}
