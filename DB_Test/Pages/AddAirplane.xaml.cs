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
using DB_Test.Windows;
using DB_Test.Domain;

namespace DB_Test.Pages
{
    /// <summary>
    /// Interaction logic for AddAirplane.xaml
    /// </summary>
    public partial class AddAirplane : Page
    {
        Win_OCC w;
        public AddAirplane(Win_OCC win)
        {
            InitializeComponent();
            w = win;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Airplanes a = new Airplanes(w);
            w.frame.Navigate(a);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            w.SaveAirplane(new AirPlane(nametxt.Text, regtxt.Text, Engtxt.Text, equtxt.Text, Convert.ToInt32(FCStxt.Text), Convert.ToInt32(BCStxt.Text), Convert.ToInt32(ECStxt.Text), 0, 0));
        }
    }
}
