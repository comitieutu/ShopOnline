using System.ComponentModel.DataAnnotations;

namespace ComiShop.ViewModels
{
    public class ReceiveProductViewModel
    {
        [Required]
        public string ShipToName { get; set; }
        [Required]
        public string ShipToPhone { get; set; }
        [Required]
        public string ShipToAddress { get; set; }
        [Required]
        public string ShipToStreet { get; set; }
        [Required]
        public string ShipToDistrict { get; set; }
        [Required]
        public string ShipToCity { get; set; }
        [Required]
        public string ShipToCountry { get; set; }
    }
}
