using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eCommerceAPI.Domain.Models
{
    public class OrderDetails 
    {
        [Key]
        public int OrderDetailsId { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int OrderId { get; set; } 
        public virtual Orders Orders { get; set; }
        public int ProductId { get; set; } 
        public  List<Products> Products { get; set; }
    } 
}
