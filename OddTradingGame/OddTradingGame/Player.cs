using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddTradingGame
{
    internal class Player
    {
        public string name;
        public List<Item> inventory = new List<Item>();
        //Item collectable;

        public Player()
        {

        }

        public Player(string thisName, List<Item> stuff)
        {
            name = thisName;
            inventory = stuff;
        }
    }
}
