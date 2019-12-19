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
    /// Interaction logic for Airplanes.xaml
    /// </summary>
    public partial class Airplanes : Page
    {
        Win_OCC w;
        public Airplanes(Win_OCC win)
        {
            InitializeComponent();
            w = win;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddAirplane a = new AddAirplane(w);
            w.frame.Navigate(a);
        }
    }
}
