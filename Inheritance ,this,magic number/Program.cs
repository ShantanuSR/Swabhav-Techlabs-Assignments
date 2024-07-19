using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIsARelationship.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Clerk(2,"Om",30,30000,5000);
            Print(employee1);

            Console.WriteLine();

            Employee employee2 = new Manager(3, "Prasad", 27, 35000, 6000);
            Print(employee2);
            

        }

        static void Print(Employee employee)
        {
            Console.WriteLine(employee.GetType().Name);
            Console.WriteLine(employee.PrintDetails());
        }

    }
}
