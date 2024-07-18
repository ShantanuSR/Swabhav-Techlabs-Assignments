using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[3]
            {
                new Player(1,"Shantanu"),
                new Player(2,"Prasad",27),
                new Player(3,"Sarvesh",25)
            };

            Console.WriteLine(Player.WhoIsElder(players));

        }
    }
}
