using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eCommerceAPI.Domain.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public float Weight { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ImageLocation { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public int StockAmount { get; set; }

        public int CategoryId { get; set; }
        public List<Categories> Categories { get; set; }
        public virtual OrderDetails OrderDetails { get; set; } 

    }
}
