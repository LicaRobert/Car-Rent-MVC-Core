using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarRentWebApp.Models
{
    public partial class Customers
    {
        [Required]
        [DisplayName("Client ID")]
        public int CostumerId { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [MinAge(18)]
        [MaxAge(65)]
        public DateTime BirthDate { get; set; }

        [Required]
        [DisplayName("Location")]
        public string Location { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
