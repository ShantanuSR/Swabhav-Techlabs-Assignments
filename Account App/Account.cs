using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankingApp
{
    internal class Account
    {
        public int PersonId {  get; set; }
        public string PersonName { get; set; }
        public double Balance{ get; set; }

        public const double MIN_BALANCE = 500;

        public Account() { }

        public Account(int personId, string personName) : this(personId, personName, MIN_BALANCE)
        {

        }

        public Account(int personId, string personName, double balance)
        {
            PersonId = personId;
            PersonName = personName;
            Balance = balance;
        }

        
        public bool Deposit(double amount)
        {
            Balance += amount;
            return true;
        }
        public bool Withdraw(double amount)
        {
            if (Balance > MIN_BALANCE)
            {
                Balance -= amount;
                Console.WriteLine("Withdraw sucessfully.");
                return true;
            }
            
            else
            {
                Console.WriteLine("Low balance.");
                return false;
            }
            

        }

           


    }
}
