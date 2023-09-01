using Microsoft.EntityFrameworkCore;
using ShıpmentFormAplicationInNetCore.Models;

namespace ShıpmentFormAplicationInNetCore.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly OrderShipmentContext _dbContext;
        public CustomerService(OrderShipmentContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            var customers = await _dbContext.Customer.ToListAsync();
            return customers;
        }

    }
}
