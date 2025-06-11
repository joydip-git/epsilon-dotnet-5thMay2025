using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace ProductsAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        [Route("all")]
        public string GetProducts()
        {
            logger.LogInformation(this.HttpContext.Request.GetDisplayUrl());
            return "products";
        }

        [HttpGet]
        [Route("view/{id}")]
        //public string GetProduct(int id)
        public string GetProduct([FromRoute(Name = "id")] int productId)
        {
            logger.LogInformation(this.HttpContext.Request.GetDisplayUrl());
            return "product " + productId;
        }
    }
}
