using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    class Player
    {
        private int _playerId { get; set; }
        private string _playerName {  get; set; }
        private int _playerAge{  get; set; }

        public Player(int playerId,string playerName):this(playerId,playerName,0)
        {

        }

        public Player(int playerId, string playerName,int playerAge) 
        {
            _playerId = playerId;
            _playerName = playerName;
            _playerAge = playerAge;
        }

        public static string WhoIsElder(Player[] players)
        {
            int maxAge = 0;
            int elderPlayerId=0;
            string nameOfPlayer = " ";
            foreach (Player player in players)
            {
                if (maxAge < player._playerAge)
                {
                    maxAge = player._playerAge;
                    elderPlayerId= player._playerId;
                    nameOfPlayer = player._playerName;
                }    
            }
            return ("Max age : "+ maxAge + "\nPlayer Id : "+elderPlayerId+"\nPlayer name : "+nameOfPlayer);
        }
    }
}
