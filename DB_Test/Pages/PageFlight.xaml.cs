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
    /// Interaction logic for PageFlight.xaml
    /// </summary>
    public partial class PageFlight : Page
    {
        Win_OCC win;
        public PageFlight(Win_OCC window)
        {
            InitializeComponent();
            win = window;
        }

        private void AddFlight_Click(object sender, RoutedEventArgs e)
        {
            //data grid
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {

            flightLog a = new flightLog(win);
            win.frame.Navigate(a);
        }

        private void Flights_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(flights.SelectedIndex>=0)
            {

            }
        }
    }
}
