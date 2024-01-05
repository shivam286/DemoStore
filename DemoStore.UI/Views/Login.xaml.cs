using DemoStore.DataAccess.Models;
using DemoStore.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace DemoStore.UI.Views
{ 
    public partial class Login : Window
    {
        private readonly LoginViewModel _context;
        private readonly CartViewModel _cartVM;
        private readonly Registration registration;
        readonly MainWindow mainWindow;
        public Login()
        {

            InitializeComponent();
            _context = new LoginViewModel();
            _cartVM = new CartViewModel();
            mainWindow = new MainWindow();
            registration = mainWindow.registrationControl;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;


        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string email = emailBox.Text;
            string password = passwordBox.Password;
            if (_context.Verify(email, password))
            {
                Close();
                
                ShowMainWindow(email);
            }
            else
            {
                MessageBox.Show("Incorrect usrname or password!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void  ShowMainWindow(string email)
        {
            mainWindow.userName.Text = "Welcome! " + email.ToLower();
            mainWindow.user = mainWindow.userName.Text.Replace("Welcome! ", "").ToLower();
            mainWindow.userId = _context.GetAdminUserId(mainWindow.user);
            mainWindow.cartId = _cartVM.GetCartId(mainWindow.userId);
            mainWindow.cartItems = _cartVM.GetCartItems(mainWindow.cartId);
            if (mainWindow.cartItems.Count != 0)
            {
                foreach (var cartItem in mainWindow.cartItems)
                {
                    mainWindow.CartItemsCollection.Add(cartItem);
                }

            }
            if(mainWindow.cartId !=0)
               registration.cart = new ObservableCollection<Cart>
                    {
                        _cartVM.GetCartDetailsById(mainWindow.cartId)
                    };
            else
                {
                registration.cart.Clear();
                    mainWindow.cartId = _cartVM.CreateCart(mainWindow.userId);
                    registration.cart.Add(_cartVM.GetCartDetailsById(mainWindow.cartId));
                }

            registration.SetGrandTotal(registration.cart[0].Total);
            registration.SetSubTotal(registration.cart[0].SubTotal);
            registration.SetTax(registration.cart[0].TotalTax);

            if (registration.producsToAdd.Count != 0)
                registration.clearCartBtn.Visibility = Visibility.Visible;
            
            registration.itemCount.Text = "(" + registration.producsToAdd.Count + ")";
            if (!string.IsNullOrEmpty(registration.cart[0].DiscountType) &&
                (registration.cart[0].DiscountPercent!=0 || registration.cart[0].DiscountPercent != null))
                {
                registration.discountTxtBox.Text = registration.cart[0].DiscountPercent.ToString();
                registration.discountCmbBox.Text = registration.cart[0].DiscountType;
                registration.discountItemsControl.ItemsSource = registration.cart;
                registration.discountPriceItemsControl.ItemsSource = registration.cart;
                registration.SetApplyButtonContent();

            }

            registration.createCartContainer.ItemsSource = null;
            registration.createCartContainer.ItemsSource = registration.producsToAdd;
            mainWindow.Show();
        }
    }
}
