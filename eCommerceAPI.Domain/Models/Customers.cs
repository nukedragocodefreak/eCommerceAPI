using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eCommerceAPI.Domain.Models
{
    public class Customers 
    {
        [Key]
        public int Customerid { get; set; }
        [Required]
        public string Customername { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string BillingAddress { get; set; }
        [Required]
        public string ShippingAddress { get; set; }
        [Required]
        public string Phonenumber { get; set; }
        public int CountryId { get; set; } 
        public virtual Country Country { get; set; }
        public List<Orders> Orders { get; set; }

    }
}
