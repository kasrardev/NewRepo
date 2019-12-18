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
using DB_Test.Windows;

namespace DB_Test.Pages
{
    /// <summary>
    /// Interaction logic for FADetail.xaml
    /// </summary>
    public partial class FADetail : Page
    {
        Win_OCC w;
        public FADetail(Win_OCC win)
        {
            InitializeComponent();
            w = win;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FlightAttendent a = new FlightAttendent(w);
            w.frame.Navigate(a);
        }
    }
}
