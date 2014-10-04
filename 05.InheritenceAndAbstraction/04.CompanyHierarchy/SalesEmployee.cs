using System;
using System.Collections.Generic;

namespace _04.CompanyHierarchy
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private IList<Sale> sales;

        public SalesEmployee(int id, string firstname, string lastname, decimal salary, Departments department, IList<Sale> sales)
            : base(id, firstname, lastname, salary, department)
        {
            this.Sales = sales;
        }

        public IList<Sale> Sales
        {
            get { return this.sales; }
            set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentNullException("Sales Can't be empty");
                }

                this.sales = value;
            }
        }

        public override string ToString()
        {
            string setS = "";
            bool isFirst = true;
            foreach (var item in this.sales)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    setS += ", ";
                }

                setS += item.Name;
            }
            return base.ToString() + " | Sales: " + setS;
        }
    }
}
