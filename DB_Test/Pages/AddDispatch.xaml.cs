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
    /// Interaction logic for AddDispatch.xaml
    /// </summary>
    public partial class AddDispatch : Page
    {
        Win_OCC w;
        public AddDispatch(Win_OCC win)
        {
            InitializeComponent();
            w = win;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Dispath a = new Dispath(w);
            w.frame.Navigate(a);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string[] a = new string[3];
            a = birth.Text.Split('-');
            DateTime birthday = new DateTime(Convert.ToInt32(a[0]), Convert.ToInt32(a[1]), Convert.ToInt32(a[2]));
            w.SaveDispatch(new Dispatcher(fnametxt.Text, lnametxt.Text, idtxt.Text, NIdtxt.Text, birthday, licNotxt.Text));
        }
    }
}
