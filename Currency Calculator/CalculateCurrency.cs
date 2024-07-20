using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Currency
{
    internal class CalculateCurrency
    {
        public void Currency(int amount)
        {
            int[] NotesArray = new int[4] { 2000, 500, 200, 100 };
            string[] NotesArray2 = new string[4] { "Two Thousand ", "Five Hundred ", "Two Hundred", "Hundred" };

            int[] NotesCounterArray = new int[4];

            for (int i = 0; i < 4; i++)
            {
                if (amount >= NotesArray[i])
                {
                    NotesCounterArray[i] = amount / NotesArray[i];
                    amount = amount % NotesArray[i];
                }
            }

            
            for (int i = 0; i < 4; i++)
            {
                if (NotesCounterArray[i] != 0)
                {
                    Console.WriteLine(NotesArray2[i] + " : " + NotesCounterArray[i]);
                }
            }


        }
    }
}
