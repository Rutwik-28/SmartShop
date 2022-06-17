using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartShop.Models
{
    public class Categories
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category Name should not be blank")]
        [StringLength(30, MinimumLength = 5)]
        public string CategoryName { get; set; }

        //public virtual ICollection<Product> Products { get; set; }
    }
}
