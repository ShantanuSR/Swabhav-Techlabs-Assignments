using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class Employee
    {
        private string _employeeName;
        private string _companyName;
        private string _companyLocation;

        public Employee(string employeeName,string companyName,string companyLocation)
        {
            _employeeName = employeeName;  
            _companyName = companyName;
            _companyLocation = companyLocation;
        }

        public  string PrintDetails()
        {
            return ("Developer name is :" + _employeeName + "\nCompany name is : "+_companyName+"\nLocation : "+_companyLocation);
        }
    }
}
