using DemoStore.DataAccess.Models;
using DemoStore.ViewModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DemoStore.UI.Views
{

    public partial class ShoppingItems : UserControl
    {
        private readonly ProductViewModel _product;
        private readonly CategoryViewModel _category;

        public void CreateProductGrid(List<Product> products)
        {
            productsContainer.ItemsSource = null;

            List<Product> productDataList = new List<Product>();

            foreach (var item in products)
            {
                productDataList.Add(new Product
                {
                    Id = item.Id,
                    Name = item.Name,
                    SellPrice = item.SellPrice
                });
            }
            productsContainer.ItemsSource = productDataList;

        }

        public ShoppingItems()
        {
            DataContext = this;
            InitializeComponent();
            _product = new ProductViewModel();
            _category = new CategoryViewModel();

            List<Product> products = _product.GetProducts();
            CreateProductGrid(products);


        }


        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            string searchText = searchBox.Text.ToLower(); ;
            List<Product> products = _product.GetProductByName(searchText);
            CreateProductGrid(products);

        }


        public void CreateProductGridByCategory(string name)
        {
            if(name == "All Categories")
            {
                CreateProductGrid(_product.GetProducts());
                return;
            }
            long id = _category.GetCategoryIdByName(name);
            List<Product> products = _product.GetProductByCategory(id);
            CreateProductGrid(products);

        }

        private void AddToCart(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            Registration registrationControl = ((MainWindow)Window.GetWindow(this)).registrationControl;

            Product product = clickedButton.DataContext as Product;

            if (product != null)
            {
                registrationControl.CreateCartProducts(product);
            }


        }
    }
}
