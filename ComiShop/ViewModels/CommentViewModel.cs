using ComiShop.Models;

namespace ComiShop.ViewModels
{
    public class CommentViewModel
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public string Context { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
