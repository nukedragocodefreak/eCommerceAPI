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
    public class CustomerRepository : ICustomers
    {
        private readonly ECommerceDBContext _context;
        public CustomerRepository(ECommerceDBContext context) 
        {
            _context = context;
        }
        public async Task<Domain.Models.Customers> GetCustomersByIdAsync(int id)
        {
            var response = _context.Customers.Select(x => x.Customerid == id);

            return (Domain.Models.Customers)response;
        }
    }
}
