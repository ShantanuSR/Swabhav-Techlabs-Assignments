using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDesignPattern.GlobalInterface;

namespace StateDesignPattern.Model
{
    public class DebitCardInserted : IATM
    {
        public void InsertDebit()
        {
            Console.WriteLine("Atm Inserted");
        }
        public void EnterPin()
        {
            Console.WriteLine("Correct PIN");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Money withdrawn successfully");
        }

        public void EjectCard()
        {
            Console.WriteLine("Card has been removed ");
        }
    }
}
