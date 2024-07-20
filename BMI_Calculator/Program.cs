using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Person person1 = new Person(1,"Ram",20);
           
            Person person2 = new Person(2,"Prasad",21,5.4,68);
            Person person3 = new Person(2,"Prathm",23,5.6,78);
            Person person4 = new Person(2,"Shyam",24,4.9,58);

            PrintBmi(person1);
            
            PrintBmi(person2);
            PrintBmi(person3);
            PrintBmi(person4);

            Person[] PersonArray = new Person[4] { person1, person2, person3, person4 };

            Console.WriteLine("Highest bmi : " + Person.PrintPersonBMI(PersonArray));

        }

        public static void PrintBmi(Person person)
        {
            double result = person.CalculateBMI();
            Console.WriteLine(result);
            Console.WriteLine(person.BodyType(result));
            Console.WriteLine();

        }
    }
}
