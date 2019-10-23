using CarRentWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebApp.ViewModels
{
    public class CarRentViewModel
    {
        public int CarRentViewModelID { get; set; }

        [Required]
        [DisplayName("Client ID")]
        public int CustomerId { get; set; }
 
        [Required]
        [DisplayName("Car Model")]
        public string CarModel { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        public string City { get; set; }

        [DisplayName("Price Per Day")]
        public decimal PricePerDay { get; set; }


        public CarRent CarRent { get; set; }

        public Customers Customers { get; set; }

        public Cars Cars { get; set; }
    }
}
