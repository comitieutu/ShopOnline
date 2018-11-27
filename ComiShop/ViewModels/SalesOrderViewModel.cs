using ComiShop.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComiShop.ViewModels
{
    public class SalesOrderViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public bool OrderStatus { get; set; }
        public double TotalPrice { get; set; }
        [Column(TypeName = "date")]
        public DateTime ShippedDate { get; set; }
        public bool Payment { get; set; }
        public int ShipperId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
