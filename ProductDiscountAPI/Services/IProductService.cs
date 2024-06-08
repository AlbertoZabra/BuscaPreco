using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductDiscountAPI.Models;

namespace ProductDiscountAPI.Services;

    public interface IProductService
    {
        Product AddProduct(ProductDTO productDto);
        Product GetProductById(int id);
        List<Product> GetAllProducts();
    }
