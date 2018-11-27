using System.ComponentModel.DataAnnotations;

namespace ComiShop.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required]
        [MaxLength(250,ErrorMessage = "Too long")]
        public string Mesage { get; set; }
    }
}
