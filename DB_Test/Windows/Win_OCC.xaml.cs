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
using System.Windows.Shapes;
using DB_Test.Pages;
using DB_Test.Windows;
namespace DB_Test.Windows
{
    /// <summary>
    /// Interaction logic for Win_OCC.xaml
    /// </summary>
    public partial class Win_OCC : Window
    {
        public Win_OCC()
        {
            InitializeComponent();
            IMG_Mahan.Visibility = Visibility.Visible;

        }

        private void GridMenu_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_open_drawer.Visibility = Visibility.Visible;
            btn_close_drawer.Visibility = Visibility.Collapsed;
            //Change Lables Margin
            //Thickness margin = lbl_UserName.Margin;
            //margin.Left = margin.Left-140;
            //lbl_UserName.Margin = margin;

            //Thickness margin2 = lbl_UserName_Static.Margin;
            //margin2.Left = margin2.Left - 140;
            //lbl_UserName_Static.Margin = margin2;

            //Thickness margin3 = lbl_UserFamily.Margin;
            //margin3.Left = margin3.Left - 140;
            //lbl_UserFamily.Margin = margin3;

            //Thickness margin4 = lbl_UserFamily_static.Margin;
            //margin4.Left = margin4.Left - 140;
            //lbl_UserFamily_static.Margin = margin4;
        }

        private void GridMenu_MouseEnter(object sender, MouseEventArgs e)
        {
            btn_open_drawer.Visibility = Visibility.Collapsed;
            btn_close_drawer.Visibility = Visibility.Visible;
            //Change Lables Margin
            Thickness margin = lbl_UserName.Margin;
            //margin.Left =margin.Left+140;
            //lbl_UserName.Margin = margin;

            //Thickness margin2 = lbl_UserName_Static.Margin;
            //margin2.Left = margin2.Left + 140;
            //lbl_UserName_Static.Margin = margin2;

            //Thickness margin3 = lbl_UserFamily.Margin;
            //margin3.Left = margin3.Left + 140;
            //lbl_UserFamily.Margin = margin3;


            //Thickness margin4 = lbl_UserFamily_static.Margin;
            //margin4.Left = margin4.Left + 140;
            //lbl_UserFamily_static.Margin = margin4;
        }

        private void btn_close_drawer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_open_drawer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_home_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn_Reports_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       

        private void FlightLOgBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PageFlight a = new PageFlight(this);
            frame.Navigate(a);
        }

        private void PilotsBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pilotPage a = new pilotPage(this);
            frame.Navigate(a);
        }

        private void FlightAttendent_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FlightAttendent a = new FlightAttendent(this);
            frame.Navigate(a);
        }

        private void Route_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Routes a = new Routes();
            frame.Navigate(a);
        }

        private void Dispatch_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Dispath a = new Dispath();
            frame.Navigate(a);
        }

        private void Reports_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Pages.Reports a = new Reports();
            frame.Navigate(a);
        }

        private void Airplane_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
