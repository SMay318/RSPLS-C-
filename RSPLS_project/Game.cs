using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS_project
{
    public class Game
    {
        Player player1;
        Player player2;
        List<string> gestures;
        public int round;


        public Game()
        {
            gestures = new List<string>() { "rock", "paper", "scissors", "Lizard", "spock" };
            round = 1;
        }
    }
}
