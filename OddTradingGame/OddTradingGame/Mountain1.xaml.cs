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
    /// Interaction logic for Mountain1.xaml
    /// </summary>
    public partial class Mountain1 : Page
    {
        public Mountain1()
        {
            InitializeComponent();

            NPC Biggoron1 = new NPC("Biggoron", "Im the world's best swordsmith. I'd love to fix something, but I need something to fix first", new Item("Prescription", 7), new Uri("Resources / Biggoron.png", UriKind.Relative));
            NPC Biggoron2 = new NPC("Biggoron", "I need my eyedrops to fix anything.\nSo, did you bring my eyedrops back yet?", new Item("Stabby Stab", 9), new Uri("Resources/Biggoron.png", UriKind.Relative));

        }
    }
}