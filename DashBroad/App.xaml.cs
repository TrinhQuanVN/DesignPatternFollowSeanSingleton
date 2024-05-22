using DashBroad.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DashBroad
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new DashbroadViewModel(

                    new CostViewModel(),
                    new ProfitViewModel(),
                    new RecentScaleViewModel(),
                    new RevenueViewModel()
                )
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
