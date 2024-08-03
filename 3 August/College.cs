using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDetails
{
    public class College
    {
        public List<Student> students = new List<Student>();
        public List<Professor> professors = new List<Professor>();
        public List<Department> departments = new List<Department>();
        public int ClgId {  get; set; }
        public string ClgName { get; set; }

        public College(int clgId, string clgName)
        {
            ClgId = clgId;
            ClgName = clgName;
        }

       

    }
}
