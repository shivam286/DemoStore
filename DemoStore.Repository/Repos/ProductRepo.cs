using DemoStore.DataAccess.Data;
using DemoStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoStore.Repository.Repos
{
    public class ProductRepo
    {
        private readonly DemoStoreContext _context;
        public ProductRepo()
        {
            _context = new DemoStoreContext();
        }
        public List<Product> GetProducts()
        {
            var test = _context.Products;
            if (test != null)
                return test.ToList();
            return null;
        }
        public Product? GetProductById(long id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }
        public List<Product> GetProductByName(string name)
        {
            return _context.Products.Where(p => p.Name.ToLower().Contains(name)).ToList();
        }
        public List<Product> GetProductByCategory(long id)
        {


            var queryResult = from p in _context.Products
                              join cp in _context.CategoriesProducts on p.Id equals cp.ProductId
                              join c in _context.Categories on cp.CategoryId equals c.Id
                              where cp.CategoryId == id
                              select new
                              {
                                  productId = p.Id,
                                  productName = p.Name,
                                  productSell_price = p.SellPrice,
                                  category_id = c.Id,
                                  category_name = c.Name
                              };

            var results = queryResult.ToList();

            List<Product> products = new List<Product>();
            foreach (var item in results)
            {
                products.Add(new Product { Name = item.productName, Id = item.productId, SellPrice = item.productSell_price });
            }

            return products;
        }

        public Product GetProductByBarcode(string barcode)
        {
            return _context.Products.FirstOrDefault(x => x.BarCode == barcode);
        }

        public void UpdateProductsStock(OrderItem orderItem) 
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == orderItem.ProductableId);
            if(product.StockQty > 0)
            {
            if(product.StockQty >= orderItem.Quantity)
            {
                product.StockQty -= orderItem.Quantity;
                product.UpdatedAt = DateTime.Now;
                _context.Products.Update(product);
                _context.SaveChanges();
            }
                return;
            }

            
        }
    }
}
