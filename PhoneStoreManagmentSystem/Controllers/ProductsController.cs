using Microsoft.AspNetCore.Mvc;
using PhoneStoreManagmentSystem.Data.Models;
using PhoneStoreManagmentSystem.Data.ViewModels;
using PhoneStoreManagmentSystem.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoneStoreManagmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly IProductService _productService;
        public ProductsController(IProductService service)
        {
            _productService = service;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.Produktet();
        }

        [HttpGet("GetClientByName/{name}")]
        public Product Get(string name)
        {
            return _productService.MerrProductByName(name);
        }

        [HttpPost]
        public string Post([FromBody] ProductVM value)
        {
            return _productService.Create(value);
        }

        [HttpPut]
        public string Put([FromBody] ProductVM value)
        {
            return _productService.ProductUpdate(value);
        }

        [HttpDelete("{name}")]
        public string Delete(string name)
        {
            return _productService.ProductDelete(name);
        }
    }
}
