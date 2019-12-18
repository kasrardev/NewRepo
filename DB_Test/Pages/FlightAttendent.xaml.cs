﻿using System;
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

namespace DB_Test.Pages
{
    /// <summary>
    /// Interaction logic for FlightAttendent.xaml
    /// </summary>
    public partial class FlightAttendent : Page
    {
        Windows.Win_OCC win;
        public FlightAttendent(Windows.Win_OCC w)
        {
            InitializeComponent();
            win = w;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddFlightAttendent a = new AddFlightAttendent(win);
            win.frame.Navigate(a);
        }

        private void Flights_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FADetail a = new FADetail(win);
            win.frame.Navigate(a);
        }
    }
}
