using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIsARelationship.cs
{
    class Manager : Employee
    {
        private double _empIncentive;
        public Manager(int empId, string empName, int empAge, double empSalary, double incentive) : base(empId, empName, empAge, empSalary)
        {
            this._empIncentive = incentive;
        }

        public override string PrintDetails()
        {
            return (base.PrintDetails() + "\nEmployee Incentive  : " + _empIncentive);

        }
    }
}
