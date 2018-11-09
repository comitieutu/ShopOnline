using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
