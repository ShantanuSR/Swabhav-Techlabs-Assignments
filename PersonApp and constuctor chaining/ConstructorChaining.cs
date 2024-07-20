using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constuctor_Chaining
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Man man = new Man("Ram","Aranyak",50);
            Console.WriteLine(man.printDetails());

            Console.WriteLine();

            Man man2 = new Man("Laxman", "Airoli", 45, 5.4);
            Console.WriteLine(man2.printDetails());
        }
    }

    class Man 
    {
        private string _manName;
        private string _manAddress;
        private int _manAge;
        private double _manHeight;

        public Man(string manName,string manAddress,int manAge):this(manName,manAddress,manAge,0)
        {

        }

        public Man(string manName, string manAddress, int manAge, double manHeight) 
        {

            _manName = manName;
            _manAddress = manAddress;
            _manAge = manAge;
            _manHeight = manHeight;
        }



        public virtual string printDetails()
        {
            return("Name : "+ _manName +"\nAddress : "+ _manAddress+ "\nAge : "+ _manAge+"\nHeight : " + _manHeight);
        }

        
    }

    
}
