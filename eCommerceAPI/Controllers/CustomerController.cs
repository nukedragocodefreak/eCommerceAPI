using eCommerceAPI.Application.Repository;
using eCommerceAPI.Core.Interfaces;
using eCommerceAPI.Domain.Models;
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
    public class CustomerController : ControllerBase
    {

        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomers _customers;

        public CustomerController(ILogger<CustomerController> logger, ICustomers customers)
        {
            _logger = logger;
            _customers = customers;
        }

        [HttpGet("{id}")]
        public IEnumerable<Domain.Models.Customers> Get(int id)
        {
            var response = _customers.GetCustomersByIdAsync(id);
            return (IEnumerable<Customers>)response;
        }
    }
}
