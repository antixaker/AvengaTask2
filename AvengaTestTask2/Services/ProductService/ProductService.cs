using System;
using System.Collections.Generic;
using System.Linq;
using AvengaTestTask2.Models;

namespace AvengaTestTask2.Services.ProductService
{
    public class ProductService : IProductService
    {
        public decimal GetProductPrice(Product product)
        {
            if (product.PricingMethod == PricingMethods.PerPound)
            {
                if (product.Weight.HasValue)
                {
                    return product.Weight.Value * product.Price;
                }

                return 0;
            }
            else if (product.PricingMethod == PricingMethods.PerItem)
            {
                if (product.Quantity.HasValue)
                {
                    return product.Quantity.Value * product.Price;
                }

                return 0;
            }
            else
            {
                throw new ApplicationException("Unknown PricingMethod type for product");
            }
        }

        public decimal GetProductsPrice(IList<Product> products)
        {
            return products.Sum(p => GetProductPrice(p));
        }
    }
}
