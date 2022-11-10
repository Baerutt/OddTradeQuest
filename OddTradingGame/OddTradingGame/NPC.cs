using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddTradingGame
{
    public class NPC
    {
        string name;
        string distressStatement;
        Item tradable;

        public NPC()
        {

        }

        public NPC(string myName, string myDistressStatement, Item myItem)
        {
            name = myName;  
            distressStatement = myDistressStatement;
            tradable = myItem;
        }

        public void ShowMe()
        {
            //distressStatement
        }
        public void Trigger(Item itsATrade)
        {
            if(tradable.ID == itsATrade.ID - 1)
            {
                //"A " + itsATrade.name + "...for me..?\nThank you so much! Here's a " + +
            }
            else
            {

            }
        }


    }
}
