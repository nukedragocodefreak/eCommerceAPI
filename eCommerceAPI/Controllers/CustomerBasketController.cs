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
    public class CustomerBasketController : ControllerBase
    {

        private readonly ILogger<CustomerBasketController> _logger;
        private readonly ICustomerBasket _customerBasket;

        public CustomerBasketController(ILogger<CustomerBasketController> logger, ICustomerBasket customerBasket)
        {
            _logger = logger;
            _customerBasket = customerBasket;
        }

        [HttpGet("{id}/{Quantity}/{CustomerId}")]
        public IEnumerable<Domain.Models.Orders> Get(int id, int Quantity, int CustomerId)
        {
            try
            {
                var response = _customerBasket.AddCustomerBasketAsync(id, Quantity, CustomerId);
                return (IEnumerable<Orders>)response;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
                throw;
               
            }

        }

        [HttpGet("{value}")]
        public IEnumerable<float> GetValue(float value)
        {
            try
            {
                var response = _customerBasket.GetCurrentValueAsync(value);
                return (IEnumerable<float>)response;
            }
            catch (Exception ex)
            {
               _logger.LogInformation(ex.Message);
                throw;
            }

        }

        [HttpGet("{value}/{discountpolicyid}")]
        public IEnumerable<float> GetValue(float value, int discountpolicyid)
        {
            try
            {
                var response = _customerBasket.CalculateDiscountAsync(value, discountpolicyid);
                return (IEnumerable<float>)response;
            }
            catch (Exception)
            {
                _logger.LogInformation(ex.Message);
                throw;
            }
        }
    }
}
