using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComiShop.ViewModels
{
    public class ProductDetailViewModel
    {
        public ProductListViewModel ProductListViewModel { get; set; }
        public List<CommentViewModel> CommentViewModels { get; set; }
        public CommentCreateViewModel CommentCreateViewModel { get; set; }
        public int Id { get; set; }
        public string ProductName { get; set; }

        [StringLength(50)]
        public string ProductDes { get; set; }
        [StringLength(50)]
        public string DesDetail { get; set; }
        public int CategoryId { get; set; }

        public string CategoryName { get;set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }
        public List<string> ProductImage { get; set; }
    }
}
