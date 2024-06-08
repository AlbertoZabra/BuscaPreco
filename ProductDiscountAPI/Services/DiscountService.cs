using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductDiscountAPI.Models;


namespace ProductDiscountAPI.Services;

    public class DiscountService : IDiscountService
    {
        private readonly IProductService _productService;

        public DiscountService(IProductService productService)
        {
            _productService = productService;
        }

        public decimal CalculateDiscountedPrice(int productId, double discountPercentage)
        {
            var product = _productService.GetProductById(productId);
            if (product == null) return 0;
            var discountAmount = product.Price * (decimal)(discountPercentage / 100);
            return product.Price - discountAmount;
        }
    }
