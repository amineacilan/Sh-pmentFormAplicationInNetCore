using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShıpmentFormAplicationInNetCore.Models;
using ShıpmentFormAplicationInNetCore.Services;

namespace ShıpmentFormAplicationInNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _customerService.GetAllCustomers();
        }



    }
}
