using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShıpmentFormAplicationInNetCore.Models;
using ShıpmentFormAplicationInNetCore.Services;

namespace ShıpmentFormAplicationInNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return  await _productService.GetAllProducts();
        }


    }
}
