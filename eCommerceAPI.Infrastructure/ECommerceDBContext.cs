using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceAPI.Infrastructure
{
    public class ECommerceDBContext: DbContext
    {
        public ECommerceDBContext(DbContextOptions<ECommerceDBContext> options) : base(options)
        { 
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<DiscountPolicy> DiscountPolicy { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
