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
    /// Interaction logic for AddPilot.xaml
    /// </summary>
    public partial class AddPilot : Page
    {
        Win_OCC w;
        public AddPilot(Win_OCC win)
        {
            InitializeComponent();
            w = win;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            pilotPage a = new pilotPage(w);
            w.frame.Navigate(a);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
