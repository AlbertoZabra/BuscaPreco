using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductDiscountAPI.Data;
using ProductDiscountAPI.Models;
using System.Collections.Generic;

namespace ProductDiscountAPI.Services;

    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product AddProduct(ProductDTO productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price
            };
            return _productRepository.AddProduct(product);
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
    }

