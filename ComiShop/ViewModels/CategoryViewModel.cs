using System.ComponentModel.DataAnnotations;

namespace ComiShop.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string CategoryName { get; set; }

        [StringLength(50)]
        public string CategoryDes { get; set; }
        public int Parent { get; set; }
        public bool IsDeleteAble { get; set; }
    }
}
