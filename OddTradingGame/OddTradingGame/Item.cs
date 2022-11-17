using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddTradingGame
{
    public class Item
    {
        public string name;
        public int ID;

        public Item()
        {

        }
        public Item(string thisName, int thisID)
        {
            name = thisName;
            ID = thisID;
        }
    }
}
