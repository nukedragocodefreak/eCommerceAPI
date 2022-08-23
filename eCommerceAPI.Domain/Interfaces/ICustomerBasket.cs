using eCommerceAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Core.Interfaces
{
    public interface ICustomerBasket
    {
        Orders AddCustomerBasketAsync(int id, int Quantity, int CustomerId);
        Task<float> GetCurrentValueAsync(float value);
        Task<float>  CalculateDiscountAsync(float value, int discountpolicyid); 
    }
}
