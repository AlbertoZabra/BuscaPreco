using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductDiscountAPI.Services;

namespace ProductDiscountAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet("{productId}/{discountPercentage}")]
        public ActionResult<decimal> GetDiscountedPrice(int productId, double discountPercentage)
        {
            var discountedPrice = _discountService.CalculateDiscountedPrice(productId, discountPercentage);
            return Ok(discountedPrice);
        }
    }
