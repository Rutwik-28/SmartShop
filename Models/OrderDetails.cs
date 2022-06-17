using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartShop.Models
{
    public class OrderDetails
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [ForeignKey("BillId")]
        public int BillId { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }

        [ForeignKey("AddressId")]
        public int AddressId { get; set; }

        [DisplayName("ProductQuantity")]
        [Required]
        public int ProductQuantity { get; set; }

        [DisplayName("Price")]
        [Required]
        public decimal Price { get; set; }

        [DisplayName("TotalAmount")]
        public decimal TotalAmount { get; set; }

        /*public virtual BillDetail BillDetail { get; set; }
        public virtual Contact Contact { get; set; }*/
    }
}
