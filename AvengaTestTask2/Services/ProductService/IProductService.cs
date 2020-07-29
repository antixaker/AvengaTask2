using System;
using System.Collections.Generic;
using AvengaTestTask2.Models;
using Refactoring;

namespace AvengaTestTask2.Services.ProductService
{
    public interface IProductService
    {
        decimal GetProductPrice(Product product);
        decimal GetProductsPrice(IList<Product> products);
    }
}
