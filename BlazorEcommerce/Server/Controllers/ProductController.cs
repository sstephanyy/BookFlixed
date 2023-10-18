using BlazorEcommerce.Server.Services.ProductService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly InProductService _productService; 
        public ProductController(InProductService productService)  // Dependency injection is often used in ASP.NET Core to provide the controller with the required services
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
        {

            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }
    }
}
