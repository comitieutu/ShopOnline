namespace BookStore
{
    using BookStore.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleOrderDetail")]
    public partial class SaleOrderDetail : BaseEntity
    {
        [StringLength(7)]
        public string SaleOrderDetailId { get; set; }

        [StringLength(7)]
        public string SaleOrderId { get; set; }

        [StringLength(7)]
        public string ProductId { get; set; }

        public int? Quantity { get; set; }

        public double? UnitPrice { get; set; }

        public int? Discount { get; set; }

        public bool? Deleted { get; set; }

        public virtual Product Product { get; set; }

        public virtual SaleOrder SaleOrder { get; set; }
    }
}
