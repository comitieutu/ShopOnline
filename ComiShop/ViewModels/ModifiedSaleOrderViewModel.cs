using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComiShop.ViewModels
{
    public class ModifiedSaleOrderViewModel
    {
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime ShippedDate { get; set; }
        public bool Payment { get; set; }
        public int ShipperId { get; set; }
    }
}
