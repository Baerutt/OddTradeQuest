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
    /// Interaction logic for Forest1.xaml
    /// </summary>
    public partial class Forest1 : Page
    {
        public Forest1()
        {
            InitializeComponent();

            ImageSourceConverter ISC = new ImageSourceConverter();
            NPC ThisGuy = new NPC("This Guy", "Oh no! My poor Smurf Chick... where have you run to...\nI'll give you something in return if you can\nfind him and bring him back!", new Item("Dope Shroom", 3), new Uri("Resources/ThisGuy.png", UriKind.Relative));
            NPC CreepyGirl = new NPC("Creepy Girl", "Man, I am starving. Oh, the old guy? \nHe's Dead. I'll give you something in return if you can\ngive me something to eat.", new Item("Jiggy Saw", 5), new Uri("Resources/CreepyGirl.png", UriKind.Relative));

            //ForestNPC.Source = (ImageSource)ISC.ConvertFrom("Resources/ThisGuy.png");



        }
    }
}
