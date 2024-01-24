using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows;

namespace DemoStore.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       public static InvoiceProperty InvoiceProperty { get; set; } = new InvoiceProperty();

        private MainViewModel _viewModel;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Create the view model and subscribe to network changes
            _viewModel = new MainViewModel();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            // Unsubscribe from network changes when the application exits
            NetworkChange.NetworkAvailabilityChanged -= _viewModel.NetworkAvailabilityChangedHandler;
        }
    }
}
