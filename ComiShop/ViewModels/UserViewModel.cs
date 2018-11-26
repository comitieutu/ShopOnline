using Microsoft.EntityFrameworkCore.Metadata;

namespace ComiShop.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string BankAccount { get; set; } 
    }
}
