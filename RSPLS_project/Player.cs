using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS_project
{
    public abstract class Player
    {
        public int total;
        public string choice;
        public string name;

        public Player()
        {
            total = 0;
        }

        public abstract string ChooseGesture(List<string> gestures, Player player);

        public void IncreaseTotal()
        {
            total++;
        }
    }
}
