using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OddTradingGame
{
    /// <summary>
    /// Interaction logic for Pharmacy1.xaml
    /// </summary>
    public partial class Pharmacy1 : Page
    {
        public Pharmacy1()
        {
           
            NPC Granny1 = new NPC("Granny", "If only I had something to make a potion with... Then I'd be happy\nIf you give me that item, I might be able to cook something for you", new Item("Odd Potluck", 4), new Uri("Resources/Granny.png", UriKind.Relative));
            NPC Granny2 = new NPC("Granny", "I have a patient that's coming soon\nI'll just need his prescription and I'll be all set to hand this off", new Item("World's Biggest Eyedrops", 8), new Uri("Resources/Granny.png", UriKind.Relative));

        }

    }
}
