using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS_project
{
    public class Human : Player
    {
        public string type;


        public Human()
        {
            type = "human";
        }

        public override string ChooseGesture(List<string> gestures, Player player)
        {
            string userGesture;
              
        }
    }
}
