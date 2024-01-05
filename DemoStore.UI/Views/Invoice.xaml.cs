using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DemoStore.UI.Views
{
    public partial class Invoice : System.Windows.Controls.UserControl
    {
        public Invoice()
        {
            InitializeComponent();
            DataContext = App.InvoiceProperty;
        }

        private void PrintBtn(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new();

           
            printDialog.PrintVisual(printGrid, "Invoice");
        }


        private void NewOrder_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.registrationControl.Visibility = Visibility.Visible;
            mainWindow.invoiceControl.Visibility = Visibility.Collapsed;
        }
    }
}

