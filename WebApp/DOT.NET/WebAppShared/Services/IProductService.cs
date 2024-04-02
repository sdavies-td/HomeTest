using WebApp.Shared.Entities;

namespace WebApp.Shared.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductById(int id);
        Task<Product> AddProduct(Product product);
        Task<Product> EditProduct(int id, Product product);
        Task<bool> DeleteProduct(int id);
    }
}
