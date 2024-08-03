using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDetails
{
    public class Student
    {
        public int StuId { get; set; }
        public string StuName { get; set; }

        public Student(int stuId,string stuName) 
        {
            StuId = stuId;
            StuName = stuName;

        }

    }
}
