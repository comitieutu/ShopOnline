using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComiShop.ViewModels
{
    public class ProductCreateViewModel
    {
        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string ProductDes { get; set; }
        [StringLength(50)]
        public string DesDetail { get; set; }
        
        public int CategoryId { get; set; }

        public int? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        [Required]
        public List<CategoryViewModel> CategoryView { get; set; }
    }
}
