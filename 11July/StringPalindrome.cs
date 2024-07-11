using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String: ");
            string stringInput = Console.ReadLine();
            Console.WriteLine(CheckStringPalindrome(stringInput));
        }
        static string CheckStringPalindrome(string input)
        {
            String inputString = input.ToLower();

            char[] originalString = inputString.ToCharArray();
            Array.Reverse(originalString);
            
            string reverseString = new string(originalString);

            if(inputString == reverseString)
            {
                return "String is Palindrome";
            }
            return  "String is not a Palindrome";
            
            


        }
    }
}
