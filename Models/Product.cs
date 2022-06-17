using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartShop.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [ForeignKey("CatId")]
        public int CatId { get; set; }

        [DisplayName("ProductName")]
        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "Product name cannot be empty")]
        public string ProductName { get; set; }

        [StringLength(50, MinimumLength = 5)]
        [DisplayName("BrandName")]
        [Required(ErrorMessage = "Brand name cannot be empty")]
        public string BrandName { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Price cannot be empty")]
        public decimal Price { get; set; }

        [DisplayName("Quantity")]
        [Required(ErrorMessage = "Quantity cannot be empty")]
        public int Quantity { get; set; }

        [DisplayName("Product Image")]
        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "Product Image cannot be empty")]
        public string ProductImage { get; set; }

        [DisplayName("Description")]
        [StringLength(1000, MinimumLength = 20)]
        [Required(ErrorMessage = "Description cannot be empty")]
        public string Description { get; set; }

        [Required(ErrorMessage = "best before cannot be empty")]
        [DisplayName("BestBefore")]
        public DateTime ExpiryDate { get; set; }

        [DisplayName("Rating")]
        public int Rating { get; set; }

       /* public virtual UserDetail UserDetail { get; set; }
        public virtual ICollection<Category> Category { get; set; }*/
    }
}
