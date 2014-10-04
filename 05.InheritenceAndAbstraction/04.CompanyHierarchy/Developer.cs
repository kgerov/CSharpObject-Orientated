using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CompanyHierarchy
{
    class Developer : RegularEmployee, IDeveloper
    {
        private IList<IProject> projects;

        public Developer(int id, string firstname, string lastname, decimal salary, Departments department, IList<IProject> projects)
            : base(id, firstname, lastname, salary, department)
        {
            this.Projects = projects;
        }

        public IList<IProject> Projects
        {
            get
            {
                return this.projects;
            }
            set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentNullException("Projects have to 1 or more than 1");
                }

                this.projects = value;
            }
        }

        public override string ToString()
        {
            string setP = "";
            bool isFirst = true;
            foreach (var item in this.Projects)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    setP += ", ";
                }

                setP += item.Name;
            }

            return base.ToString()  + " | Projects: " + setP;
        }
    }
}
