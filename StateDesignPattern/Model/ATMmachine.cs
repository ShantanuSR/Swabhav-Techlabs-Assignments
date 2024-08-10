using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDesignPattern.GlobalInterface;

namespace StateDesignPattern.Model
{
    public class ATMmachine : IATM
    {
        public IATM atm;

        public ATMmachine()
        {
            atm = new DebitNotInserted();
        }

        public void InsertDebit()
        {
            atm.InsertDebit();
            if (atm is DebitNotInserted)
            {
                atm = new DebitCardInserted();
                Console.WriteLine($"ATM state changed to {atm.GetType().Name}");
            }
        }
        public void EnterPin()
        {
            atm.EnterPin();

        }

        public void WithdrawMoney()
        {
            atm.WithdrawMoney();
           
        }

        public void EjectCard()
        {

        }
    }
}
