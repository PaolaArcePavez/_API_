using _API_.IServices;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace _API_.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }
        [HttpPost(Name = "InsertProduct")]
        public int Post([FromBody] Product product)
        {
            //     _userService.ValidateCredentials(userItem);
            return _productService.InsertProduct(product);
        }

        [HttpGet(Name = "GetAllProducts")]
        public List<Product> GetAll()
        {
            //     _userService.ValidateCredentials(userItem);
            return _productService.GetAllProducts();
        }
        [HttpGet(Name = "GetProductsByCriteria")]
        public List<Product> GetByCriteria(bool IsActive)
        {

            return _productService.GetProductsByCriteria();
        }

        
    }
}
