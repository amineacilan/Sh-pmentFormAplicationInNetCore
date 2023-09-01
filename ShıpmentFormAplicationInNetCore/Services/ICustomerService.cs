using ShıpmentFormAplicationInNetCore.Models;

namespace ShıpmentFormAplicationInNetCore.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomers();
    }
}
