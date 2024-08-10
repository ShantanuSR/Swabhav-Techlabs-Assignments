using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDesignPattern.GlobalInterface;

namespace StateDesignPattern.Model
{
    
        public class DebitNotInserted : IATM
        {
            public void InsertDebit()
            {
                Console.WriteLine("ATM card Not Inserted");
            }
            public void EnterPin()
            {

                Console.WriteLine("ATM card not inserted");
            }

            public void WithdrawMoney()
            {

                Console.WriteLine("Please insert Debit card first");
            }
        }
    }

