using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string inputString = Console.ReadLine();
            string[] inputArray = inputString.Split( new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries );
            Console.WriteLine("Number of words : " + inputArray.Length);
        }
    }
}
