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
    /// Interaction logic for Desert1.xaml
    /// </summary>
    public partial class Desert1 : Page
    {
        public Desert1()
        {
            {
                InitializeComponent();
                NPC craftsman = new NPC("Craftsman", "I would love to start working, but I seem to missing my saw.\nDo you have it?", new Item("Broken Sword", 6), new Uri("Resources/Craftsman.png", UriKind.Relative));

            }
        }
    }
}

