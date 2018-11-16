﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.ViewModels
{
    public class CategoryViewModel
    {
        public string CategoryId { get; set; }
        [StringLength(20)]
        public string CategoryName { get; set; }

        [StringLength(50)]
        public string CategoryDes { get; set; }
    }
}
