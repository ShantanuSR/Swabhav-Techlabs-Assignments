using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProf
{
   abstract class Person
    {
        private int _personId;

        private string _personAddress;

        private string _personDateOfBirth;

        public virtual double CalculateSalary()
        {
            return 0;
        }

        public Person(int personId, string personAddress, string personDateOfBirth)
        {
            _personId = personId;
            _personAddress = personAddress;
            _personDateOfBirth = personDateOfBirth;
        }

        public virtual string PrintDetails()
        {
            return ("Person Id : "+_personId + "\nAddress : "+ _personAddress+ "\nDate of bitrh : "+ _personDateOfBirth );
        }

        

    }
}
