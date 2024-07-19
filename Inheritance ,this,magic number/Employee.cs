using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIsARelationship.cs
{
     class Employee
    {
        private int _empId;
        private string _empName;
        private int _empAge;
        private double _empSalary;

        public Employee(int empId, string empName, int empAge, double empSalary)
        {
            this._empId = empId;
            this._empName = empName;
            this._empAge = empAge;
            this._empSalary = empSalary;
        }

        public virtual string PrintDetails()
        {
            return("Employee Id : " + _empId + "\nEmployee Name : " + _empName + "\nEmployee age : " + _empAge + "\nEmployee Salary : " + _empSalary);
        }
        
    }

    
    
}
