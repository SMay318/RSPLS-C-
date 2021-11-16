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
            DisplayWelcome();
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to RSPLS");

        }

        public void SetUpGame()
        {

        }

        public void RunGame()
        {

        }

        public Player GetNewPlayer(Player player, bool isPlayer1)
        {
            string playerType;

            Console.WriteLine("What type of player is Player 1? Choose 'human' or 'ai'");
            playerType = Console.ReadLine().ToLower();


            switch(playerType)
            {
                case "human":
            }
        }

        public void WinnerOfRound()
        {

        }

        public void WinnerOfGame()
        {

        }
    }
}
