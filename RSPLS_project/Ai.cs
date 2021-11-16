using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS_project
{
    public class Ai : Player
    {
        public Random random;
        public string type;

        public Ai()
        {
            random = new Random();
            type = "ai";
        }

        public override string ChooseGesture(List<string> gestures, Player player)
        {
            string AiGesture;

            AiGesture = gestures[random.Next(0, 5)];
            Console.WriteLine(player.name + " chose {0} ", AiGesture);
            Console.ReadLine();
            return AiGesture;
        }
    }
}
