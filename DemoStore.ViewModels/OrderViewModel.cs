
using DemoStore.DataAccess.Models;
using DemoStore.Repository.Repos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
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

            //convert the object to json
            var obj = JsonConvert.SerializeObject(order);

            //send this order to queue
            Console.WriteLine(obj);
        }

        public void AddOrderItems(List<OrderItem> items)
        {
            _context.AddOrderItems(items);
        }
    }
}
