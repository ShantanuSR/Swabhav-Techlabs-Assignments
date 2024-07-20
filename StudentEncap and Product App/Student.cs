using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace StudentEncapsulation
{
    internal class Student
    {
        private int _stuRollNum;
        private string _stuName;
        private float _stuCgpa;
        public int GetStudentRollNumber()
        {
            return _stuRollNum;
        }
        public string GetStudentName()
        {
            return _stuName;
        }
        public float GetStudentCgpa()
        {
            return _stuCgpa;
        }
        public void SetStuRollNum(int rollNoOfStu)
        {
            if (rollNoOfStu > 0)
            {
                _stuRollNum = rollNoOfStu;
            }
            else
            {
                Console.WriteLine("Roll Number can't be Negative");
                Console.WriteLine();
            }
        }
        public void SetStuName(string studentName)
        {
            _stuName = (studentName.Length < 5) ? "" : studentName;
        }
        public void SetStuCgpa(float studentCgpa)
        {
            if (1 <= studentCgpa && studentCgpa <= 10)
            {
                _stuCgpa = studentCgpa;
            }
            else
            {
                Console.WriteLine("CGPA should be between 1 to 10");
                Console.WriteLine();
            }
        }

        public void GetPercentage()
        {
            Console.WriteLine("Percentage : "+_stuCgpa*9.5 + "%");
        }

    }
}
