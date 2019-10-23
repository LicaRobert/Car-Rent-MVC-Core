using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebApp.Models
{
    public class CarRentCount
    {
        [Key]
        [DisplayName("Car Model")]
        public string Name { get; set; }

        [DisplayName("Number of rents")]
        public int Total { get; set; }
    }
}
