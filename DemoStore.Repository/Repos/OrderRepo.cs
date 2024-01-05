
using DemoStore.DataAccess.Data;
using DemoStore.DataAccess.Models;
using System;
using System.Collections.Generic;

namespace DemoStore.Repository.Repos
{
    public class OrderRepo
    {
        private readonly DemoStoreContext _context;
        public OrderRepo()
        {
            _context = new DemoStoreContext();
        }

        public void AddOrder(Order order)
        {
            order.CreatedAt = DateTime.Now;
            order.UpdatedAt = DateTime.Now;
            order.PlacedAt = DateTime.Now;
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
        public void AddOrderItems(List<OrderItem> order)
        {
            _context.OrderItems.AddRange(order);
            _context.SaveChanges();
        }
    }
}
