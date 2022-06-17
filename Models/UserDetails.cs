using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartShop.Models
{
    public class UserDetails
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [ForeignKey("UserType")]
        public string UserType { get; set; }

        [DisplayName("First Name")]
        [StringLength(30, MinimumLength = 5)]
        [Required(ErrorMessage = "First Name can't be blank")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [StringLength(30, MinimumLength = 5)]
        [Required(ErrorMessage = "Last Name can't be blank")]
        public string LastName { get; set; }

        [StringLength(30, MinimumLength = 8)]//length
        [DisplayName("UserName")]
        [Required(ErrorMessage = "User Name can't be blank")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Date of Birth can't be blank")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Please select gender")]
        public string Gender { get; set; }

        [RegularExpression(@"^\[0-9]{3}\ [0-9]{3}-[0-9]{4}$")]//check reg expression_
        [Required(ErrorMessage = "Enter Correct Phone Number")]
        public int PhoneNo { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Enail id can`t be blank")]
        public string Email { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password can`t be blank")]
        public string Password { get; set; }

        [ForeignKey("SqId")]
        [Required(ErrorMessage = "Select Security Question")]
        public int SecurityQuestionId { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required(ErrorMessage = "Security answer cannot be empty")]
        public string SecurityAnswer { get; set; }

       // public virtual ICollection<UserDetail> UserDetails { get; set; }



    }
}
