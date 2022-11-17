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
    /// Interaction logic for Village1.xaml
    /// </summary>
    public partial class Village1 : Page
    {
        public Village1()
        {
            InitializeComponent();
            NPC CuccooLady = new NPC("Cuccoo Lady", "Oh no! I've lost my White Chick... \nI'll give you something in return if you can\nfind him and bring him back!", new Item("Smurf Chick", 2), new Uri("Resources/CuccoLady.png", UriKind.Relative));


        }


    }
}
