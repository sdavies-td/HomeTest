using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Shared.Data;
using WebApp.Shared.Entities;

namespace WebApp.Shared.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<Product> AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var dbProduct = await _context.Products.FindAsync(id);
            if (dbProduct != null)
            {
                _context.Remove(dbProduct);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Product> EditProduct(int id, Product product)
        {
            var dbProduct = await _context.Products.FindAsync(id);
            if (dbProduct != null)
            {
                dbProduct.Name = product.Name;
                await _context.SaveChangesAsync();
                return dbProduct;
            }
            throw new Exception("Product not found.");
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            await Task.Delay(500);

            var products = await _context.Products.ToListAsync();
            return products;
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}
