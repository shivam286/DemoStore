using DemoStore.DataAccess.Models;
using DemoStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace DemoStore.UI.Views
{

    public partial class Registration : UserControl
    {
        public MainWindow mainWindow;

        private MainViewModel _networkHandler;

        public ObservableCollection<CartItem> producsToAdd;
        public ObservableCollection<Cart> cart = new();
        private readonly CartViewModel _cartVM;
        private readonly ProductViewModel _productVM;
        private readonly OrderViewModel _orderVM;
        private readonly UserViewModel _userVM;
        private readonly InvoiceProperty _invoice;
        private Queue<Order> _orders;
        string paymentMethod;
       
        public Registration()
        {
            NetworkChange.NetworkAvailabilityChanged += NetworkAvailabilityChangedHandler;

            InitializeComponent();
            _cartVM = new CartViewModel();
            _productVM = new ProductViewModel();
            _orderVM = new OrderViewModel();
            _userVM = new UserViewModel();
            _invoice = App.InvoiceProperty;
            _networkHandler = new();
            _orders = new();
            mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (mainWindow!=null) producsToAdd = mainWindow.CartItemsCollection;
        }

        private void NetworkAvailabilityChangedHandler(object? sender, NetworkAvailabilityEventArgs e)
        {
            if (_networkHandler.IsOnline)
            {
                try
                {
                    foreach (Order o in _orders)
                    {
                        //send data to api
                        //dequeue the _orderList
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        public void CreateCartProducts(Product products)
        {

            mainWindow.invoiceControl.Visibility = Visibility.Collapsed;
            mainWindow.registrationControl.Visibility = Visibility.Visible;
            Product product = _productVM.GetProduct(products.Id);
            if(product.StockQty <= 0)
            {
                MessageBox.Show(product.Name + " " + " is out of stock!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var listItem = producsToAdd.FirstOrDefault(i => i.ProductableId == products.Id && i.CartId == mainWindow.cartId);

            

            if (listItem != null)
            {
                
                CalculateForProduct( listItem, listItem.Quantity + 1,listItem.Quantity);
                
            }
            else
            {
                CartItem cartItems = new()
                {
                    ProductableId = products.Id,
                    ProductName = products.Name,
                    Quantity = 1,
                    UnitPrice = products.SellPrice,
                    CartId = (int?)cart[0].Id,
                    PriceWithoutTax = products.PriceWithoutTax

                };

                cartItems.TotalPrice = products.SellPrice * cartItems.Quantity;
                cartItems.TaxAmount = products.TaxAmount * cartItems.Quantity;
                cartItems.PriceWithoutTax = products.PriceWithoutTax * cartItems.Quantity;
                producsToAdd.Add(cartItems);
                _cartVM.AddCartItem(cartItems);
                cart[0].TotalTax += cartItems.TaxAmount;
                cart[0].Total += cartItems.TotalPrice;
                cart[0].TotalWithTax += cartItems.TotalPrice;
            }
            CalculateSubAndGrandTotal();

            createCartContainer.ItemsSource = null;
            createCartContainer.ItemsSource = producsToAdd;
            cart[0].UpdatedAt = DateTime.Now;

            if (producsToAdd.Count != 0)
                clearCartBtn.Visibility = Visibility.Visible;
            itemCount.Text = "(" + producsToAdd.Count + ")";

        }
        private void IncreaseQuantity_Click(object sender, RoutedEventArgs e)
        {
            Button increaseButton = (Button)sender;
            TextBox associatedTextBox = (TextBox)increaseButton.Tag;
            TextBlock associatedPriceBlock = (TextBlock)associatedTextBox.Tag;
            StackPanel container = (StackPanel)increaseButton.Parent;
            long productId = (long)container.Tag;
            Product product = _productVM.GetProduct(productId);
           
            int currentQuantity = int.Parse(associatedTextBox.Text);
            int oldQuantity = int.Parse(associatedTextBox.Text);
            currentQuantity++;
            var listItem = producsToAdd.FirstOrDefault(i => i.ProductableId == productId && i.CartId == mainWindow.cartId);
            CalculateForProduct(listItem, currentQuantity, oldQuantity);
            CalculateSubAndGrandTotal();
            cart[0].UpdatedAt = DateTime.Now;
            _cartVM.UpdateCart(cart[0]);
            createCartContainer.ItemsSource = null;
            createCartContainer.ItemsSource = producsToAdd;

        }

        private void DecreaseQuantity_Click(object sender, RoutedEventArgs e)
        {
            Button decreaseButton = (Button)sender;
            TextBox associatedTextBox = (TextBox)decreaseButton.Tag;
            StackPanel container = (StackPanel)decreaseButton.Parent;
            long productId = (long)container.Tag;

            int currentQuantity = int.Parse(associatedTextBox.Text);
            int oldQuantity = int.Parse(associatedTextBox.Text);
            if (currentQuantity > 0)
            {
                currentQuantity--;
                var listItem = producsToAdd.FirstOrDefault(i => i.ProductableId == productId && i.CartId == mainWindow.cartId);
                if (currentQuantity <= 0)
                {
                    DeleteFromCart(listItem);
                    CalculateSubAndGrandTotal();
                    if (producsToAdd.Count == 0)
                        clearCartBtn.Visibility = Visibility.Collapsed;
                    itemCount.Text = "(" + producsToAdd.Count + ")";
                    return;

                }
                CalculateForProduct(listItem, currentQuantity, oldQuantity);
                CalculateSubAndGrandTotal();
                cart[0].UpdatedAt = DateTime.Now;
                _cartVM.UpdateCart(cart[0]);
                createCartContainer.ItemsSource = null;
                createCartContainer.ItemsSource = producsToAdd;
                if (producsToAdd.Count == 0)
                    clearCartBtn.Visibility = Visibility.Collapsed;
                itemCount.Text = "(" + producsToAdd.Count + ")";
            }


        }

        private void RemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            Button removeButton = (Button)sender;
            long productId = (long)removeButton.Tag;
            var listItem = producsToAdd.FirstOrDefault(i => i.ProductableId == productId && i.CartId == mainWindow.cartId);
            DeleteFromCart(listItem);
            cart[0].UpdatedAt = DateTime.Now;
            cart[0].TotalWithTax-=listItem.TotalPrice;
            cart[0].Total-=listItem.TotalPrice;
            cart[0].TotalTax-=listItem.TaxAmount;
            CalculateSubAndGrandTotal();
            if (producsToAdd.Count == 0)
                clearCartBtn.Visibility = Visibility.Collapsed;
            itemCount.Text = "(" + producsToAdd.Count + ")";

        }

        public void CalculateSubAndGrandTotal()
        {
            decimal? subTotal = 0,totaltax = 0;
            foreach (var item in producsToAdd)
            {
                var product = _productVM.GetProduct((int)item.ProductableId);
                subTotal += product.PriceWithoutTax * item.Quantity;
                totaltax += product.TaxAmount * item.Quantity;
            }
            cart[0].SubTotal = subTotal;
            cart[0].TotalTax = totaltax;
            CalculateGrandTotal();
            SetTax(totaltax);
            SetSubTotal(subTotal);

        }

        public decimal? CalculateDiscount(decimal? calcNo, decimal discountNo, string discountType)
        {
            decimal? total = calcNo;
            decimal? discount;
            if ((discountNo<1 || discountNo>100) && discountType.ToLower() == "percent")
            {

                 MessageBox.Show("Discount Must Be Between 1-100!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                discountTxtBox.Text = null;
                return total;

            }
            if (discountNo >= calcNo  && discountType.ToLower() == "flat")
            {

                MessageBox.Show("Discount Can Not Be Greater Than The Price!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                discountTxtBox.Text = null;
                return total;

            }
            if (discountType.ToLower() == "percent")
            {
                
                discount = (calcNo / 100) * discountNo;
                cart[0].DiscountPercent = discountNo;
            }
            else
            {
                
                discount = discountNo;
            }
            total -= discount;
            cart[0].AppliedDiscount = discount; 
            cart[0].DiscountType = discountType; 
            cart[0].Total = total; 
            cart[0].TotalWithTax = total; 
            cart[0].TotalWithoutDiscount = calcNo; 

            SetDiscount(discount,total);
            return total;
        }

        public void SetDiscount(decimal? discount,decimal? total)
        {
            if (discount != 0)
            {

                cart[0].AppliedDiscount = discount;
                cart[0].Total = total;
                discountItemsControl.ItemsSource = null;
                discountItemsControl.ItemsSource = cart;
                discountPriceItemsControl.ItemsSource = null;
                discountPriceItemsControl.ItemsSource = cart;

                _cartVM.UpdateCart(cart[0]);
            }
        }
        public void SetTax(decimal? tax)
        {
           cart[0].TotalTax = tax;
           taxPrice.Text = ("\u20B9") + tax.ToString();
        }
        public void DeleteFromCart(CartItem cartItem)
        {
            producsToAdd.Remove(cartItem);
            _cartVM.DeleteCartItem(cartItem);
        }

        public void CalculateForProduct(CartItem cartItem, int? quantity, int? oldQuantity)
        {
            int index = producsToAdd.IndexOf(cartItem);
            cartItem.TotalPrice = quantity * (cartItem.TotalPrice / oldQuantity);
            cartItem.Quantity = quantity;
            producsToAdd[index] = cartItem;
            cart[0].Total -= cartItem.TotalPrice * oldQuantity;
            cart[0].TotalWithTax -= cart[0].Total;
            cart[0].TotalTax -= cartItem.TaxAmount * oldQuantity;

            cart[0].Total += cartItem.TotalPrice * quantity;
            cart[0].TotalWithTax += cart[0].Total;
            cart[0].TotalTax += cartItem.TaxAmount * quantity;
            _cartVM.UpdateCartItem(cartItem);

            
        }

        private void ApplyDiscount_Click(object sender, RoutedEventArgs e)
        {
           
            SetApplyButtonContent();
            CalculateGrandTotal();
        }

        public void CalculateGrandTotal()
        {
            decimal? subTotal;
            decimal? tax;
            subTotal = cart[0].SubTotal;
            tax = cart[0].TotalTax;
            decimal? totaToCalculate = subTotal+tax;
            if (!string.IsNullOrEmpty(discountTxtBox.Text) && decimal.TryParse(discountTxtBox.Text, out decimal discount))
            {
                ComboBoxItem discountCmb = discountCmbBox.SelectedItem as ComboBoxItem;
                string discountType = discountCmb.Content.ToString();
                decimal? total = CalculateDiscount(totaToCalculate, discount, discountType);
                cart[0].Total = total;
                cart[0].TotalWithTax = totaToCalculate;

                SetGrandTotal(total);
            }
            else
            {
                SetGrandTotal(totaToCalculate);
                cart[0].Total = totaToCalculate;
                cart[0].TotalWithTax = totaToCalculate;
            }
            _cartVM.UpdateCart(cart[0]);
        }

        public void SetApplyButtonContent()
        {
            if (applyBtn.Content == "Remove")
            {

                discountTxtBox.Text = string.Empty;
                cart[0].AppliedDiscount = 0.0m;
                cart[0].DiscountType = null;
                cart[0].DiscountPercent = null;
                discountItemsControl.ItemsSource = null;
                discountPriceItemsControl.ItemsSource = null;
            }
            if (!string.IsNullOrWhiteSpace(discountTxtBox.Text) && 0 != Convert.ToDecimal(discountTxtBox.Text))
            {

                applyBtn.Content = "Remove";
                applyBtn.Background = Brushes.Black;
                applyBtn.Foreground = Brushes.White;
            }
            else
            {

                applyBtn.Content = "Apply";

                applyBtn.Background = (Brush)FindResource("HoverBackgroundColor"); ;
                applyBtn.Foreground = Brushes.Black;
            }
        }
        public void SetGrandTotal(decimal? grandTotal)
        {
            grandTotalPrice.Text = ("\u20B9") + grandTotal.ToString();
        }
        public void SetSubTotal(decimal? subTotal)
        {
            subTotalPrice.Text = ("\u20B9") + subTotal.ToString();
        }
        private void ClearCart_Click(object sender, RoutedEventArgs e)
        {

            ClearCart();
        }

        private void ClearCart()
        {
            producsToAdd.Clear();
            createCartContainer.ItemsSource = null;
            createCartContainer.ItemsSource = producsToAdd;
            _cartVM.ClearCart(mainWindow.cartId);
            clearCartBtn.Visibility = Visibility.Collapsed;

            cart[0].AppliedDiscount = 0.0m;
            cart[0].Total = 0.0m;
            cart[0].TotalTax = 0.0m;
            cart[0].TotalWithoutDiscount = 0.0m;
            cart[0].TotalWithTax = 0.0m;
            cart[0].SubTotal = 0.0m;
            cart[0].DiscountPercent = 0.0m;
            discountTxtBox.Text = null;

            SetSubTotal(decimal.Parse("0.0"));
            SetGrandTotal(decimal.Parse("0.0"));
            SetTax(decimal.Parse("0.0"));
            SetApplyButtonContent();
            itemCount.Text = "(" + producsToAdd.Count + ")";
            _cartVM.UpdateCart(cart[0]);
        }

        private void TxtBarcode_TextChanged(object sender, TextChangedEventArgs e)
        {
            var barcode = txtBarcode.Text;
            if (!string.IsNullOrWhiteSpace(barcode))
            {
                var product = _productVM.ProductGetProductByBarcode(barcode);
                if(product != null)
                {

                         CreateCartProducts(product);
                }
            }
        }

        private void PaymentButton_Click(object sender, RoutedEventArgs e)
        {
            if(producsToAdd.Count != 0)
            {
                var mobile = txtMobile.Text; var name = txtName.Text;
                if (!string.IsNullOrEmpty(mobile) && !string.IsNullOrEmpty(name))
                {
                    if(paymentMethod == null)
                    {
                        MessageBox.Show("Please select payment method!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    var user = _userVM.GetUser(name, mobile);
                    var userId =0L;
                    if ( user == null)
                    {
                       userId= _userVM.AddUser(name, mobile);
                    }
                    else userId = user.Id;
                    Order order = new()
                    {
                        AdminUserId = cart[0].UserId,
                        PosOrder = true,
                        Total = cart[0].Total,
                        TotalTax = cart[0].TotalTax,
                        TotalWithTax = cart[0].TotalWithTax,
                        SubTotal = cart[0].SubTotal,
                        AppliedDiscount = cart[0].AppliedDiscount,
                        DiscountPercent = cart[0].DiscountPercent,
                        DiscountType = cart[0].DiscountType,
                        CartId = cart[0].Id.ToString(),
                        Status = "placed",
                        PlacedAt = DateTime.Now,
                        PaymentMethod = paymentMethod,
                        UserId = (int?)userId,
                        DueAmount = Convert.ToDecimal(amountTxtBox.Text)

                    };
                    _orderVM.AddOrder(order);

                    //make a queue and insert object

                    _orders.Enqueue(order);

                    List<OrderItem> orderItems = new();

                    foreach(var item in producsToAdd)
                    {
                        orderItems.Add(new OrderItem {
                            ProductName = item.ProductName,
                            PriceWithoutTax = item.PriceWithoutTax,
                            TotalPrice = item.TotalPrice,
                            UnitPrice = item.UnitPrice,
                            ProductableId = item.ProductableId,
                            CreatedAt = DateTime.Now,
                            TaxAmount = item.TaxAmount,
                            OrderId = (int?)order.Id,
                            Quantity = item.Quantity,
                            
                            });

                    }

                    _orderVM.AddOrderItems(orderItems);
                    foreach(var item in orderItems)
                       _productVM.UpdateProductsStock(item); 
                    MessageBox.Show("Order Placed Successfully!","Success",MessageBoxButton.OK, MessageBoxImage.Information);
                    mainWindow.registrationControl.Visibility = Visibility.Collapsed;
                    CallInvoiceControl();
                    ClearCart();
                    mainWindow.registrationControl.partialAmountPanel.Visibility = Visibility.Collapsed;
                    mainWindow.registrationControl.amountTxtBox.Text = 0.00.ToString();
                    mainWindow.registrationControl.onlinePaymentOptions.Visibility = Visibility.Collapsed;
                    mainWindow.registrationControl.txtMobile.Text = null;
                    mainWindow.registrationControl.txtName.Text = null;
                    return;
                }
                else
                {
                    MessageBox.Show("Mobile number and name can not be empty!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }

            MessageBox.Show("Your cart is empty. Please add item in your cart!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);


        }

        private void CallInvoiceControl()
        {
            _invoice.ProductsToAdd = new ObservableCollection<CartItem> (producsToAdd);
            mainWindow.invoiceControl.createInvoiceContainer.ItemsSource = null;
            mainWindow.invoiceControl.createInvoiceContainer.ItemsSource = _invoice.ProductsToAdd;
            _invoice.SubTotal = cart[0].SubTotal;
            _invoice.GrandTotal = cart[0].Total;
            _invoice.TaxTotal = cart[0].TotalTax;
            mainWindow.invoiceControl.Visibility = Visibility.Visible;

        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.IsChecked == true)
            {
                if(radioButton.Parent == paymentOptions)
                {

                    if (radioButton == cashRadioBtn)
                    {
                    onlinePaymentOptions.Visibility= onlinePaymentOptions.Visibility == Visibility.Visible 
                                                     ? Visibility.Collapsed : Visibility.Collapsed;
                    partialAmountPanel.Visibility = Visibility.Collapsed;
                    paymentMethod = cashTxtBlk.Text;
                    }
                    else if (radioButton == cardRadioBtn)
                    {
                        onlinePaymentOptions.Visibility = onlinePaymentOptions.Visibility == Visibility.Visible
                                                     ? Visibility.Collapsed : Visibility.Collapsed;
                    partialAmountPanel.Visibility = Visibility.Collapsed;
                    paymentMethod = cardTxtBlk.Text;
                    }
                    else if (radioButton == onlineRadioBtn)
                    {
                          partialAmountPanel.Visibility = Visibility.Collapsed;
                          onlinePaymentOptions.Visibility = Visibility.Visible;

                           onlineRadioBtn.IsChecked = false;
                           paymentMethod = null;
                }
                else if (radioButton == dueRadioBtn)
                {
                    partialAmountPanel.Visibility = Visibility.Collapsed;
                    onlinePaymentOptions.Visibility = onlinePaymentOptions.Visibility == Visibility.Visible
                                                     ? Visibility.Collapsed : Visibility.Collapsed;
                    paymentMethod = "Due";
                }
                else 
                {

                        onlinePaymentOptions.Visibility = onlinePaymentOptions.Visibility == Visibility.Visible
                                                     ? Visibility.Collapsed : Visibility.Collapsed;
                    partialAmountPanel.Visibility= Visibility.Visible;
                    paymentMethod = "Partial";

                }

                }
                else
                {
                    if (radioButton == phonepeRadioBtn)
                    {
                        paymentMethod = "PhonePe";
                    }
                    else if (radioButton == paytmRadioBtn)
                    {

                        paymentMethod = "Paytm";
                    }
                    else if (radioButton == googlePayRadioBtn)
                    {
                        paymentMethod = "Google Pay";
                    }


                    paymentMethod = "BHIM UPI";

                }


            }
            }


    }
}
