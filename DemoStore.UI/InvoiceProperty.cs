using DemoStore.DataAccess.Models;
using DemoStore.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DemoStore.UI
{
    public class InvoiceProperty : INotifyPropertyChanged
    {
        //private MainWindow _mainWindow;
        //private ObservableCollection<CartItem> _producsToAdd;
        //private ObservableCollection<Cart> _cart;
        //private CartViewModel _cartVM;
        //private ProductViewModel _productVM;
        //private OrderViewModel _orderVM;
        //private UserViewModel _userVM;

        public event PropertyChangedEventHandler PropertyChanged;

        //public MainWindow MainWindow
        //{
        //    get { return _mainWindow; }
        //    set { SetProperty(ref _mainWindow, value); }
        //}

        //public ObservableCollection<CartItem> ProducsToAdd
        //{
        //    get { return _producsToAdd; }
        //    set { SetProperty(ref _producsToAdd, value); }
        //}

        //public ObservableCollection<Cart> Cart
        //{
        //    get { return _cart; }
        //    set { SetProperty(ref _cart, value); }
        //}

        //public CartViewModel CartVM
        //{
        //    get { return _cartVM; }
        //    set { SetProperty(ref _cartVM, value); }
        //}

        //public ProductViewModel ProductVM
        //{
        //    get { return _productVM; }
        //    set { SetProperty(ref _productVM, value); }
        //}

        //public OrderViewModel OrderVM
        //{
        //    get { return _orderVM; }
        //    set { SetProperty(ref _orderVM, value); }
        //}

        //public UserViewModel UserVM
        //{
        //    get { return _userVM; }
        //    set { SetProperty(ref _userVM, value); }
        //}

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }


        private ObservableCollection<CartItem> _productsToAdd;
        public ObservableCollection<CartItem> ProductsToAdd
        {
            get { return _productsToAdd; }
            set
            {
                if (_productsToAdd != value)
                {
                    _productsToAdd = value;
                    OnPropertyChanged(nameof(ProductsToAdd));
                }
            }
        }

        private decimal? _subTotal = 0.0m;
        public decimal? SubTotal
        {
            get { return _subTotal; }
            set
            {
                if (_subTotal != value)
                {
                    _subTotal = value;
                    OnPropertyChanged(nameof(SubTotal));
                }
            }
        }

        private decimal? _grandTotal = 0.0m;
        public decimal? GrandTotal
        {
            get { return _grandTotal; }
            set
            {
                if (_grandTotal != value)
                {
                    _grandTotal = value;
                    OnPropertyChanged(nameof(GrandTotal));
                }
            }
        }

        private decimal? _taxTotal = 0.0m;
        public decimal? TaxTotal
        {
            get { return _taxTotal; }
            set
            {
                if (_taxTotal != value)
                {
                    _taxTotal = value;
                    OnPropertyChanged(nameof(TaxTotal));
                }
            }
        }


    }

}
