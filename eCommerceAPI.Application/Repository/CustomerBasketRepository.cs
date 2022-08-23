using eCommerceAPI.Core.Interfaces;
using eCommerceAPI.Domain.Models;
using eCommerceAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Application.Repository
{
    public class CustomerBasketRepository : ICustomerBasket
    {
        private readonly ECommerceDBContext _context;
        public CustomerBasketRepository(ECommerceDBContext context) 
        {
            _context = context;
        }

        public Task<Orders> AddCustomerBasketAsync(int id, int Quantity, int CustomerId) 
        {

            var product = _context.Products.SingleOrDefault(c => c.ProductId == id);
            var customer = _context.Customers.SingleOrDefault(c => c.Customerid == CustomerId); 

            if (product != null)
            {
                var order = new Orders
                {
                    CustomerId = CustomerId,
                    ShippingAddress = customer.ShippingAddress,
                    TotalAmount = (float)(Quantity * product.Price),
                    DiscountpolicyId = 0,
                    OrderDate = DateTime.UtcNow,
                    OrderStatus = ""
                };

                var orderDetail = new OrderDetails
                {
                    Price = product.Price,
                    ProductId = product.ProductId,
                    Quantity = Quantity                 
                };
            }
            throw new NotImplementedException();

        }

        public async Task<float> CalculateDiscountAsync(float value, int id)
        {
            var product = _context.DiscountPolicy.SingleOrDefault(c => c.DiscountpolicyId == id);
            var response = value * (product.Percentage / 100);
            return response;
        }

        public async Task<float>  GetCurrentValueAsync(float value)
        {
            return value;
        }
    }
}
