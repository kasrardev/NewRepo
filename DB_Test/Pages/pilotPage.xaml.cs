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

namespace DB_Test.Pages
{
    /// <summary>
    /// Interaction logic for pilotPage.xaml
    /// </summary>
    public partial class pilotPage : Page
    {
        Win_OCC win;
        public pilotPage(Win_OCC w)
        {
            InitializeComponent();
            win = w;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Pilots_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PilotDetails a = new PilotDetails(win);
            win.frame.Navigate(a);
        }
    } 
}
