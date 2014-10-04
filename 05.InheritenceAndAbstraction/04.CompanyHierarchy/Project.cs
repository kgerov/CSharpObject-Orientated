using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CompanyHierarchy
{
    class Project : IProject
    {
        private string name;
        private DateTime startDate;
        private string details;
        private bool isActive;

        public Project(string name, bool isActive, DateTime startDate = default(DateTime), string details = null)
        {
            this.Name = name;
            this.IsActive = isActive;
            this.startDate = startDate;
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't be empty");
                }

                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                this.details = value;
            }
        }

        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }

        public void CloseProject()
        {
            this.isActive = false;
        }
    }
}
