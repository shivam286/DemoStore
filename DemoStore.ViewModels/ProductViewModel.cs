using DemoStore.DataAccess.Models;
using DemoStore.Repository.Repos;
using System;
using System.Collections.Generic;

namespace DemoStore.ViewModels
{
    public class ProductViewModel
    {
        private readonly ProductRepo _product;

        public ProductViewModel()
        {
            _product = new ProductRepo();
        }
        public List<Product> GetProducts()
        {
            return _product.GetProducts();
        }

        public Product? GetProduct(long id)
        {
            return _product.GetProductById(id);
        }
        public List<Product> GetProductByName(string name)
        {
            return _product.GetProductByName(name);
        }
        public List<Product> GetProductByCategory(long categoryId)
        {
            return _product.GetProductByCategory(categoryId);
        }
        public Product ProductGetProductByBarcode(string barcode)
        {
           return _product.GetProductByBarcode(barcode);
        }

        public void UpdateProductsStock(OrderItem orderItem)
        {
            _product.UpdateProductsStock(orderItem);
        }

       
    }
}
