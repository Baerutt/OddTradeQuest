using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OddTradingGame
{
    public class NPC
    {
        string name;
        string distressStatement;
        Item tradable;
        Uri selfImage;

        public NPC()
        {

        }

        public NPC(string myName, string myDistressStatement, Item myItem, Uri myImage)
        {
            name = myName;
            distressStatement = myDistressStatement;
            tradable = myItem;
            selfImage = myImage;
        }

        public bool ShowMe(List<Item> stuff)
        {

            bool canTrade = false;
            for (int i = 0; i < stuff.Count; i++)
            {
                if (stuff[i].ID == tradable.ID - 1)
                {
                    canTrade = true;
                }
            }
            return canTrade;
        }
        public void Trigger(bool canTrade)
        {
            if (canTrade)
            {
                //"A " + itsATrade.name + "...for me..?\nThank you so much! Here's a " + +
            }
            else
            {
                //"Sorry... that's not the thing I was looking for"
            }
        }


    }
}