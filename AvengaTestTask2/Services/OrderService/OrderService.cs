using System;
using System.Collections.Generic;
using AvengaTestTask2.Models;
using AvengaTestTask2.Services.ProductService;

namespace AvengaTestTask2.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IProductService _productService;
        private IList<Order> _orders;

        public OrderService()
        {
            _productService = new ProductService.ProductService();
            _orders = new List<Order>();
        }

        public Order CreateOrder(string visitorName, params Product[] products)
        {
            var order = new Order
            {
                Id = GenerateId(),//tmp solution, here could be unique ID from DB
                Visitor = visitorName,
                Products = products
            };
            _orders.Add(order);

            return order;
        }

        public decimal GetOrderPrice(Order order)
        {
            return _productService.GetProductsPrice(order.Products);
        }

        private int GenerateId()
        {
            return new Random().Next(100000, 1000000);
        }
    }
}
