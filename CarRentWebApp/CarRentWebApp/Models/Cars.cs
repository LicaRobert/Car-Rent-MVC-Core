using System.ComponentModel;

namespace CarRentWebApp.Models
{
    public partial class Cars
    {
        [DisplayName("Car ID")]
        public int CarId { get; set; }
        public string Plate { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        [DisplayName("Price Per Day")]
        public decimal PricePerDay { get; set; }
    }
}
