using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartShop.Models
{
    public class BillDetails
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [Required]
        public DateTime BillDate { get; set; }

        [Required(ErrorMessage = "Please select any one mode of purchase")]
        public string ModeOfPurchase { get; set; }

        [DisplayName("TotalBillAmount")]
        public decimal TotalBillAmt { get; set; }

       /* [ForeignKey("AddId")]
        public int AddId { get; set; }*/

        public int AddressId { get; set; }

       /* public virtual UserDetail UserDetail { get; set; }
        public virtual Address Contact { get; set; }*/
    }
}
