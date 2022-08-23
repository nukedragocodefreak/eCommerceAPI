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

    public class ProductsRepository : IProducts
    {
        private readonly ECommerceDBContext _context;
        public ProductsRepository(ECommerceDBContext context) 
        {
            _context = context;
        }
        public async Task<List<Domain.Models.Products>> GetProductsAsync()
        {
            var response = _context.Products.ToList();
            return response;
        }
    }
}
