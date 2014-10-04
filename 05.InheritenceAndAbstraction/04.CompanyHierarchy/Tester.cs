using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CompanyHierarchy
{
    class Tester
    {
        static void Main(string[] args)
        {
            SalesEmployee gosho = new SalesEmployee(20, "Gosho", "Boo", 400m, Departments.Production, new List<Sale>() { new Sale("Laptop", 120m) });
            SalesEmployee pesho = new SalesEmployee(10, "Pesho", "Moo", 800m, Departments.Accounting, new List<Sale>() { new Sale("Microchip", 60m), new Sale("Car GPS", 160m) });
            Developer misho = new Developer(23, "Misho", "Boichev", 1400m, Departments.Marketing, new List<IProject>() { new Project("Health Care", true) });
            Manager boiko = new Manager(12, "Boiko", "Borchisov", 4500m, Departments.Sales, new List<Employee>() { gosho, pesho, misho });

            List<Employee> SoftUniTeam = new List<Employee>() {
                gosho,
                pesho,
                misho,
                boiko
            };

            foreach (var employee in SoftUniTeam)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
