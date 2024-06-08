using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDiscountAPI.Services;

    public interface IDiscountService
    {
        decimal CalculateDiscountedPrice(int productId, double discountPercentage);
    }
