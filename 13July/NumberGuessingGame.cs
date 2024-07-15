using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int rInt = r.Next(1, 20);
            //Console.WriteLine(rInt);

            Console.WriteLine("Guess the number between 0 to 20 : ");
            int givenNumber = int.Parse(Console.ReadLine());

            int count = 1;

            while(rInt!=givenNumber)
            {
                if(rInt>givenNumber)
                {
                    Console.WriteLine("Choose a greater number");
                }
                if(rInt<givenNumber)
                {
                    Console.WriteLine("Choose a lesser number");
                }
                count++;
                Console.WriteLine("Guess the number between 0 to 20 : ");
                givenNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Congratulations .... You have completed the game in " + count + " attempts");


        }

       
    }
}
