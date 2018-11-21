using ComiShop.Entities;
using ComiShop.Models;

namespace ComiShop.Data.Entities
{
    public class Comment : BaseEntity
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public string Context { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Product Product { get; set; }
    }
}
