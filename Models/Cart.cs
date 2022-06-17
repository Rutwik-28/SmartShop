using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartShop.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }

        public decimal Price { get; set; }

        [Required(ErrorMessage = "Quantity cannot be empty")]
        public int Quantity { get; set; }

        public decimal TotalAmt { get; set; }


       /* public virtual UserDetail UserDetails { get; set; }*/
       

    }
}
