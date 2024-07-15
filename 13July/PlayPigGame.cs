using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
    internal class Program
    {
        public const int WINNING_SCORE = 20;
        static void Main(string[] args)
        {
            int noOfTurns = 0, totalScore = 0;

            while (totalScore < WINNING_SCORE)
            {
                noOfTurns += 1;
                int turnScore = 0;
                Console.WriteLine($"TURN {noOfTurns}");
                int newPlayerScore = NestedLoop(noOfTurns,turnScore, totalScore);
                if (newPlayerScore >= WINNING_SCORE)
                {
                    Console.WriteLine($"You win! You finished in {noOfTurns} turns!");
                    Console.WriteLine("Game Over");
                    break;
                }
            }

        }

        static int AssignRandNumber(int start, int end)
        {
            Random rnd = new Random();
            int rndInt = rnd.Next(start, end);
            return rndInt;
        }

        public static int NestedLoop(int noOfTurns,int turnScore, int totalScore)
        {
            char actionRoll = 'r';
            char actionHold = 'h';
            while (true)
            {
                Console.WriteLine("Enter 'r' to roll again, 'h' to hold.");
                char action = Convert.ToChar(Console.ReadLine());
                if (action == actionRoll)
                {
                    int rolledDiceScore = AssignRandNumber(1, 7);
                    Console.WriteLine($"You rolled: {rolledDiceScore}");

                    // no score condition
                    if (rolledDiceScore == 1)
                    {
                        Console.WriteLine("Turn over. No score");
                        turnScore = 0;
                        break;
                    }
                    else
                    {
                        //score uodate if greater than 1
                        turnScore += rolledDiceScore;
                        Console.WriteLine($"Your turn score is {turnScore} and your total score is {totalScore}");
                        if (turnScore >= WINNING_SCORE)
                        {
                            totalScore += turnScore;
                            break;
                        }
                    }
                }

                //action hold score add in main score and turn++
                else if (action == actionHold)
                {
                    noOfTurns += 1;
                    totalScore += turnScore;
                    Console.WriteLine($"Your turn score is {turnScore} and your total score is {totalScore}");
                    Console.WriteLine($"TURN {noOfTurns}");
                    Console.ReadLine();
                }

            }
            return totalScore;


        }
       
    }
}