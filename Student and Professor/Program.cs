using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Student(1,"Airoli","03/08/2003","computer");
            Person person2 = new Professor(2,"Rabale","14/08/1983",30000);

            Print(person1);
            Print(person2);
            
        }

        public static void Print(Person person)
        {
            Console.WriteLine(person.GetType().Name+"\n"+person.PrintDetails());
            Console.WriteLine();
        }
            

    }
}
