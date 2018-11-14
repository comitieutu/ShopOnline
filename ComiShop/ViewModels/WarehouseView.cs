using System.Collections.Generic;

namespace ComiShop.ViewModels
{
    public class WarehouseView
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<ProductListViewModel> ProductList { get; set; }
    }
}
