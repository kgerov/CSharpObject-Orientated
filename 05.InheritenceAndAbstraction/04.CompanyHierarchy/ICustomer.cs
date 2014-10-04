using System;

namespace _04.CompanyHierarchy
{
    interface ICustomer : IPerson
    {
        decimal NetPurchase { get; set; }
    }
}
