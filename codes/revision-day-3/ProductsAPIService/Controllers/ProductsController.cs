using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using ProductsAPIService.Models;

namespace ProductsAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> logger;
        private readonly IRepository repository;

        public ProductsController(ILogger<ProductsController> logger, IRepository repository)
        {
            this.logger = logger;
            this.repository = repository;
        }

        [HttpGet]
        [Route("all")]        
        public ActionResult<List<Product>> GetProducts()
        {
            logger.LogInformation(this.HttpContext.Request.GetDisplayUrl());
            try
            {
                var products = repository.GetAll();
                var okResult = this.Ok(products);
                return okResult;
            }
            catch (Exception ex)
            {
                return this.Problem(ex.Message);
            }
        }

        [HttpGet]
        [Route("view/{id}")]
        //public string GetProduct(int id)
        public ActionResult<Product?> GetProduct([FromRoute(Name = "id")] int productId)
        {
            logger.LogInformation(this.HttpContext.Request.GetDisplayUrl());
            try
            {
                var product = repository.Get(productId);
                return Ok(product);
            }
            catch (Exception ex)
            {
                return this.Problem(ex.Message);
            }
        }
    }
}
