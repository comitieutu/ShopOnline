﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComiShop.ViewModels
{
    public class ProductListViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDes { get; set; }
        public string DesDetail { get; set; }
        public int CategoryId { get; set; }
        public double? UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
