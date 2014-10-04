using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy
{
    class Customer : Person, ICustomer
    {
        private decimal netPurchase;

        public Customer(int id, string firstName, string lastName, decimal netPurchase)
            : base(id, firstName, lastName)
        {
            this.NetPurchase = netPurchase;
        }

        public decimal NetPurchase
        {
            get
            {
                return this.netPurchase;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Purchase Amount can't be a negative number");
                }

                this.netPurchase = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " | Net Purchase Amount: " + this.netPurchase;
        }
    }
}
