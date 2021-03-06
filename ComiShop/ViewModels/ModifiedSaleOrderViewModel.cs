﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComiShop.ViewModels
{
    public class ModifiedSaleOrderViewModel
    {
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime ShippedDate { get; set; }
        public bool OrderStatus { get; set; }
        public bool Payment { get; set; }
        public int ShipperId { get; set; }
    }
}
