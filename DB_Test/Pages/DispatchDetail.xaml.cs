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
    /// Interaction logic for DispatchDetail.xaml
    /// </summary>
    public partial class DispatchDetail : Page
    {
        Win_OCC w;
        public DispatchDetail(Win_OCC win)
        {
            InitializeComponent();
            w = win;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Dispath a = new Dispath(w);
            w.frame.Navigate(a);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
