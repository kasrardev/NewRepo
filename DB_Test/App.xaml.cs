﻿using DB_Test.Windows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DB_Test
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_StartUp(object sender, StartupEventArgs e)
        {
            Win_OCC c = new Win_OCC();
            c.ShowDialog();
        }
    }
}
