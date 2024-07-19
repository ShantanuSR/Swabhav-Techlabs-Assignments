using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProf
{
    class Professor : Person
    {
        public const double TRAVELLING_ALLOWANCE = 0.3;
        public const double HOUSE_RENT_ALLOWANCE = 0.4;
        private double _basePay;
        public Professor(int personId, string personAddress, string personDateOfBirth, double basePay) : base(personId, personAddress, personDateOfBirth)
        {
            _basePay = basePay;
        }

        public override double CalculateSalary()
        {
            double salary = _basePay+ (_basePay*TRAVELLING_ALLOWANCE)+(_basePay*HOUSE_RENT_ALLOWANCE);
            
            return salary;
        }

        public override string PrintDetails()
        {
            return (base.PrintDetails() + "\nBranch name : " + CalculateSalary());
        }

    }
}
