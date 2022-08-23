using eCommerceAPI.Application.Repository;
using eCommerceAPI.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceAPI.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        private readonly ILogger<ProductsController> _logger;
        private readonly IProducts _products;

        public ProductsController(ILogger<ProductsController> logger, IProducts  products)
        {
            _logger = logger;
            _products = products;
        }

        [HttpGet]
        public IEnumerable<Domain.Models.Products> GetAll()
        {
            var response = _products.GetProductsAsync();
            return (IEnumerable<Domain.Models.Products>)response;
        }
    }
}
