using System.ComponentModel.DataAnnotations;

namespace ComiShop.ViewModels
{
    public class CategoryCreateViewModel
    {
        [Required]
        public string CategoryName { get; set; }
        public string CategoryDes { get; set; }
        public int Parent { get; set; }
    }
}
