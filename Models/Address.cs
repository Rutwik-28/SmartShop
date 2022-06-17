using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartShop.Models
{
    public class Address
    {
        //ADDR_ID	USER_ID	ZIP code	Flat, House no., Building, Company, Apartment	Area, Colony, Street, Sector	Landmark	Town/City	State / Province 	ADDRESS_TYPE
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [DisplayName("Pin Code")]
        [Required(ErrorMessage = "Enter Valid Pin Code")]
        [RegularExpression(@"^(?!00000)[0-9]{6}$")]
        public int PinCode { get; set; }

        [DisplayName("House Name|Flat Number")]
        [Required(ErrorMessage = "Enter your House Name/Flat Number")]
        public string Line1 { get; set; }

        [DisplayName("Area|Colony")]
        [Required(ErrorMessage = "Enter your Area")]
        public string Line2 { get; set; }

        [DisplayName("Street")]
        [Required(ErrorMessage = "Enter your Street")]
        public string Line3 { get; set; }

        [DisplayName("LandMark")]
        public string LankMark { get; set; }

        [DisplayName("City")]
        [Required(ErrorMessage = "Enter your City")]
        public string City { get; set; }

        [DisplayName("State")]
        [Required(ErrorMessage = "Enter your State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Select Address Type")]
        public string Add_Type { get; set; }//Default,new,home,office

       /* public virtual UserDetail UserDetails { get; set; }*/
    }
}
