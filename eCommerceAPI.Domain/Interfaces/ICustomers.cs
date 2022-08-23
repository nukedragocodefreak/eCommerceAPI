using eCommerceAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Core.Interfaces
{
    public interface ICustomers
    {
        Task<Customers> GetCustomersByIdAsync(int id);
    }
}
