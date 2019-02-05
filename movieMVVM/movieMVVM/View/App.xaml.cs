﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace movieMVVM.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
         void Application_Startup(object sender, StartupEventArgs e)
        {

            UserView mainWindow = new UserView();

            mainWindow.Top = 100;

            mainWindow.Left = 400;

            mainWindow.Show();

        }
    }
}
