using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductDiscountAPI.Models;



namespace ProductDiscountAPI.Data;

    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();
        private int _nextId = 1;

        public Product AddProduct(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
            return product;
        }
        public Product GetProductById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
           {
                throw new KeyNotFoundException($"Produto com ID {id} não encontrado.");
            }
            return product;
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
