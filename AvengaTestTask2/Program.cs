using System;
using AvengaTestTask2;
using AvengaTestTask2.Models;
using AvengaTestTask2.Services.BillService;
using AvengaTestTask2.Services.OrderService;

namespace Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            //in app with GUI here could be resolving services from IoC container
            IOrderService _orderService = new OrderService();
            IBillService _billService = new BillService();

            var pulledPork = new Product
            {
                ProductName = "Pulled Pork",
                Price = 6.99m,
                Weight = 0.5m,
                PricingMethod = PricingMethods.PerPound,
            };
            var coke = new Product
            {
                ProductName = "Coke",
                Price = 3m,
                Quantity = 2,
                PricingMethod = PricingMethods.PerItem
            };

            var order = _orderService.CreateOrder("John Doe", pulledPork, coke);

            _billService.PrintOrderBill(order);

            Console.ReadKey();
        }
    }
}

