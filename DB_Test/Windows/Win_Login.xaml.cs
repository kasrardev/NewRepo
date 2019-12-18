using MaterialDesignThemes.Wpf;
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

namespace DB_Test.Windows
{
    /// <summary>
    /// Interaction logic for Win_Login.xaml
    /// </summary>
    public partial class Win_Login : Window
    {
        public Win_Login()
        {
            InitializeComponent();

           // DynamicDate();

        }
        
        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_name_MouseEnter(object sender, MouseEventArgs e)
        {
            txt_name.Foreground = new SolidColorBrush(Colors.Black);
        }

       
       /* private void DynamicDate()
        {
            lbl_day_week.Content = Calender.SelectedDate.PersianDayOfWeek;
            lbl_day.Content = Calender.SelectedDate.Day;
            lbl_mounth.Content = Calender.SelectedDate.MonthAsPersianMonth;
            lbl_year.Content = Calender.SelectedDate.Year;
        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var myMessageQueueID = new SnackbarMessageQueue(TimeSpan.FromMilliseconds(1000));
            snackbar_id.MessageQueue = myMessageQueueID;
            snackbar_id.MessageQueue.Enqueue("ID Number is Empty!!");

            var myMessageQueuePass = new SnackbarMessageQueue(TimeSpan.FromMilliseconds(1000));
            snackbar_pass.MessageQueue = myMessageQueuePass;
            snackbar_pass.MessageQueue.Enqueue("Password is Empty!!");
            Win_OCC a = new Win_OCC();
            this.Close();
            a.ShowDialog();
        }

        private void btn_restore_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_RestoreID.Text))
            {
                var messg = new SnackbarMessageQueue(TimeSpan.FromMilliseconds(1000));
                Snackbar_Dialog_eror.MessageQueue = messg;
                Snackbar_Dialog_eror.MessageQueue.Enqueue("Something went Wrong!");
               

            }
           
            else
            {
                Snackbar_Dialog.IsActive = true;
               
            }

            }

        private void SnackbarMessage_ActionClick(object sender, RoutedEventArgs e)
        {
            Snackbar_Dialog.IsActive = false;
            DialogHost.IsOpen = false;
        }
        
    }
}
