using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rest_api.Interfaces;
using rest_api.Models;

namespace rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productServices;

        public ProductController(IProductService productServices)
        {
            _productServices = productServices;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _productServices.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductDto productDto)
        {
            return Ok(await _productServices.Create(productDto));
        }

        
    }
}
