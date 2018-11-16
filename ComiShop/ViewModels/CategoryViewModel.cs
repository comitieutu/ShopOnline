using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComiShop.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string CategoryName { get; set; }

        [StringLength(50)]
        public string CategoryDes { get; set; }
        public bool IsDeleteAble { get; set; }
    }
}
