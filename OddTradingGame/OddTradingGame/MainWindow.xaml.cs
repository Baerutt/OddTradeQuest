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
    /// Interaction logic for MainWindow.xaml
    /// </summary> 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ContentFrame.Navigate(new Forest1());
        }

        private void LocationBox_Load(object sender, EventArgs e)
        {
            List<Location> places = new List<Location>();
            places.Add(new Location("Forest", "N/A", "N/A", "N/A"));
            places.Add(new Location("Village", "N/A", "N/A", "N/A"));
            places.Add(new Location("Pharmacy", "N/A", "N/A", "N/A"));
            places.Add(new Location("Mountain", "N/A", "N/A", "N/A"));
            places.Add(new Location("Desert", "N/A", "N/A", "N/A"));
            //Location.DataSource = places;


        }

        private void LocationBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         

        }


        private void LocationBox_DropDownClosed(object sender, EventArgs e)
        {
            if (LocationBox.Text == "Forest")
            {
                ContentFrame.Navigate(new Forest1());
            }
            else if (LocationBox.Text == "Village")
            {
                ContentFrame.Navigate(new Village1());

            }
            else if (LocationBox.Text == "Pharmacy")
            {
                ContentFrame.Navigate(new Pharmacy1());

            }
            else if (LocationBox.Text == "Mountain")
            {
                ContentFrame.Navigate(new Mountain1());

            }
            else if (LocationBox.Text == "Desert")
            {
                ContentFrame.Navigate(new Desert1());

            }
            else
            {
                ContentFrame.Navigate(new Forest1());
            }
        }
    }
}
