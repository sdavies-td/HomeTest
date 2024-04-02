using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WebApp.Shared.Entities;

namespace WebApp.Shared.Services
{
    public class ClientProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public ClientProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Product> AddProduct(Product product)
        {
            var result = await _httpClient
                .PostAsJsonAsync("/api/product", product);
            return await result.Content.ReadFromJsonAsync<Product>();
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var result = await _httpClient.DeleteAsync($"/api/product/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<Product> EditProduct(int id, Product product)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/product/{id}", product);
            return await result.Content.ReadFromJsonAsync<Product>();
        }

        public Task<List<Product>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductById(int id)
        {
            var result = await _httpClient
                .GetFromJsonAsync<Product>($"/api/product/{id}");
            return result;
        }
    }
}
