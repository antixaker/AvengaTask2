using System;
using AvengaTestTask2.Models;

namespace AvengaTestTask2.Services.OrderService
{
    public interface IOrderService
    {
        Order CreateOrder(string visitorName, params Product[] products);
        decimal GetOrderPrice(Order order);
    }
}
