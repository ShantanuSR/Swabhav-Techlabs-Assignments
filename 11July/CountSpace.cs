using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            String stringInput = Console.ReadLine();
            Console.WriteLine(CountSpace(stringInput));
            
        }

        static int CountSpace(String xyz)
        {
            int count = 0;
            foreach (char c in xyz)
            {
                if(c == ' ') 
                    count++;
            }
            return count;

        }

            
    }
}
