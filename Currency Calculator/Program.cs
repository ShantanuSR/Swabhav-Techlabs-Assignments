using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Currency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateCurrency calculateCurrency = new CalculateCurrency();
            Console.WriteLine("Enter the withdrawal amount : ");
            int inputAmount = int.Parse(Console.ReadLine());

            if (inputAmount <= 50000 && inputAmount%100==0)
                calculateCurrency.Currency(inputAmount);

            else if(inputAmount % 100 != 0)
                Console.WriteLine("Input amount should be multiple of 100");

            else
               Console.WriteLine("Amount exceeds withdrwal limit of 50000");
        }
    }
}
