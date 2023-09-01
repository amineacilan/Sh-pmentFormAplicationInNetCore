using ShıpmentFormAplicationInNetCore.Models;

namespace ShıpmentFormAplicationInNetCore.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
    }
}
