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
    /// Interaction logic for PilotDetails.xaml
    /// </summary>
    public partial class PilotDetails : Page
    {
        Win_OCC win;
        public PilotDetails(Win_OCC w)
        {
            InitializeComponent();
            win = w;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            pilotPage a = new pilotPage(win);
            win.frame.Navigate(a);
        }
    }
}
