using Microsoft.EntityFrameworkCore;
using ShıpmentFormAplicationInNetCore.Models;

namespace ShıpmentFormAplicationInNetCore.Services
{
    public class ProductService:IProductService
    {
        private readonly OrderShipmentContext _dbContext;
        public ProductService(OrderShipmentContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            var products = await _dbContext.Product.ToListAsync();
            return products;
        }
    }
}
