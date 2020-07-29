using System;
using AvengaTestTask2.Models;
using AvengaTestTask2.Services.ProductService;

namespace AvengaTestTask2.Services.BillService
{
    public class BillService : IBillService
    {
        private readonly IProductService _productService;

        public BillService()
        {
            _productService = new ProductService.ProductService();
        }

        public void PrintOrderBill(Order order)
        {
            var orderSummary = "ORDER SUMMARY FOR " + order.Visitor + ": \r\n";

            foreach (var orderProduct in order.Products)
            {
                var productPrice = 0m;
                orderSummary += orderProduct.ProductName;

                productPrice = _productService.GetProductPrice(orderProduct);

                if (orderProduct.PricingMethod == PricingMethods.PerPound)
                {
                    orderSummary += (" $" + productPrice + " (" + orderProduct.Weight + " pounds at $" + orderProduct.Price + " per pound)");
                }
                else // Per item
                {
                    orderSummary += (" $" + productPrice + " (" + orderProduct.Quantity + " items at $" + orderProduct.Price + " each)");
                }

                orderSummary += "\r\n";
            }

            Console.WriteLine(orderSummary);
            Console.WriteLine("Total Price: $" + _productService.GetProductsPrice(order.Products));
        }
    }
}
