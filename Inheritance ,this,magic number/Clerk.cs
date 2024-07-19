using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIsARelationship.cs
{
    class Clerk : Employee
    {
        private double _empBonus;



        public Clerk(int empId, String empName, int empAge, double empSalary, double bonus) : base(empId, empName, empAge, empSalary)
        {
            this._empBonus = bonus;
        }

        public override string PrintDetails()
        {
            return (base.PrintDetails() + "\nEmployee Bonus  : " + _empBonus);

        }

    }

}
