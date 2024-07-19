using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProf
{
    class Student : Person
    {
        private string _branchName;
        public Student(int personId, string personAddress, string personDateOfBirth,string branchName) : base(personId, personAddress, personDateOfBirth)
        {

            _branchName = branchName;
        }

        public override string PrintDetails()
        {
            return (base.PrintDetails()+"\nBranch name : "+ _branchName);
        }
        
    }
}
