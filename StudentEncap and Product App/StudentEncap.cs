using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student();
            Student student1 = new Student();

            student.SetStuRollNum(1);
            student.SetStuName("Rama");
            student.SetStuCgpa(11);

            
          
            
            Console.WriteLine("Student Roll Number: " + student.GetStudentRollNumber());
            Console.WriteLine("Student Name: " + student.GetStudentName());
            Console.WriteLine("Student CGPA: " + student.GetStudentCgpa());

            student.GetPercentage();

        }
    }
}
