using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eCommerceAPI.Domain.Models
{
    public class DiscountPolicy
    {
        [Key]
        public int DiscountpolicyId { get; set; }
        [Required]
        public float Percentage { get; set; }
        [Required]
        public string DiscountpolicyName { get; set; }
        public virtual Orders Orders { get; set; } 

    }
}
