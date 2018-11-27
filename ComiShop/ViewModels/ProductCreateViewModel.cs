using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComiShop.ViewModels
{
    public class ProductCreateViewModel
    {
        [Required]
        public string ProductName { get; set; }       
        public string ProductDes { get; set; }
        public string DesDetail { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public List<CategoryViewModel> CategoryView { get; set; }
    }
}
