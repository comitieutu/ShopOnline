using System.Collections.Generic;

namespace ComiShop.ViewModels
{
    public class ProductDetailViewModel
    {
        public ProductListViewModel ProductListViewModel { get; set; }
        public List<CommentViewModel> CommentViewModels { get; set; }
        public CommentCreateViewModel CommentCreateViewModel { get; set; }
    }
}
