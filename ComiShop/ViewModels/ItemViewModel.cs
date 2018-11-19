using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComiShop.ViewModels
{
    public class ItemViewModel
    {
        public Product Product { get; set; }
        public string ProductImage { get; set; }
        public int Quantity { get; set; }
    }
}
