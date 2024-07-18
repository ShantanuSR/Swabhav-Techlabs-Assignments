using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Shantanu","Aurionpro","Pune");
            Employee employee1 = new Employee("Prasad","Accenture","Airoli");
            Employee employee2 = new Employee("Sarvesh","TCS","Thane");
            PrintEmployee(employee);
            PrintEmployee(employee1);
            PrintEmployee(employee2);
            
        }

        public static void PrintEmployee(Employee employee)
        {
            Console.WriteLine();
            Console.WriteLine(employee.PrintDetails());
        }
    }
}
