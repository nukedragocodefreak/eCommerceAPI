using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eCommerceAPI.Domain.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public float TotalAmount { get; set; }
        [Required]
        public string ShippingAddress { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string OrderStatus { get; set; }

        public int DiscountpolicyId { get; set; } 
        public virtual DiscountPolicy DiscountPolicy { get; set; }
        public virtual List<OrderDetails>  OrderDetails { get; set; }
        public int CustomerId { get; set; } 
        public virtual Customers Customers { get; set; } 
    }
}
