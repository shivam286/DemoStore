
using DemoStore.DataAccess.Models;
using DemoStore.Repository.Repos;
using System.Collections.Generic;
using System.Windows.Documents;

namespace DemoStore.ViewModels
{
    public class OrderViewModel
    {
        private readonly OrderRepo _context;
        public OrderViewModel()
        {
            _context = new OrderRepo();
        }

        public void AddOrder(Order order)
        {
            _context.AddOrder(order);
        }

        public void AddOrderItems(List<OrderItem> items)
        {
            _context.AddOrderItems(items);
        }
    }
}
