using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductDiscountAPI.Models;

namespace ProductDiscountAPI.Data;

    public interface IProductRepository
    {
        Product AddProduct(Product product);
        Product GetProductById(int id);
        List<Product> GetAllProducts();
    }
