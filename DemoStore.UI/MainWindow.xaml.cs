using DemoStore.DataAccess.Models;
using DemoStore.ViewModels;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;

namespace DemoStore.UI
{
    public class RadioButtonData
    {
        public IconChar IconName { get; set; }
        public string Text { get; set; }
    }

    public partial class MainWindow : Window
    {
        private readonly CategoryViewModel _category;
        public ObservableCollection<CartItem> CartItemsCollection { get; } = new ObservableCollection<CartItem>();
        public string user;
        public long userId;
        public long cartId;
        public List<CartItem> cartItems = new();
       
        public MainWindow()
        {
            InitializeComponent();
            _category = new CategoryViewModel();
            List<Category> categories = _category.GetCategories();

            List<RadioButtonData> radioButtonDataList = new();

            foreach (var item in categories)
            {
                radioButtonDataList.Add(new RadioButtonData
                {
                    IconName = IconChar.Circle,
                    Text = item.Name
                });
            }

            radioButtonContainer.ItemsSource = radioButtonDataList;

            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);

            SendMessage(helper.Handle, 161, 2, 0);
        }

        private void pnlControlBar_MouseEnter(object sender, MouseEventArgs e)
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
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

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender; // The clicked RadioButton
            TextBlock categoryBtn = FindCategoryTextBlock(radioButton);

            string buttonText = categoryBtn.Text;
            
            shoppingItemsControl.CreateProductGridByCategory(buttonText);


        }

        private TextBlock FindCategoryTextBlock(DependencyObject parent)
        {
            if (parent == null)
            {
                return null;
            }

            int childCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childCount; i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                if (child is TextBlock textBlock && textBlock.Name == "categoryBtn")
                {
                    return textBlock;
                }

                TextBlock result = FindCategoryTextBlock(child);
                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }


    }
}
