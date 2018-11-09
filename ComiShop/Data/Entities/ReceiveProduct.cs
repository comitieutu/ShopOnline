namespace ComiShop
{
    using ComiShop.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ReceiveProduct")]
    public partial class ReceiveProduct : BaseEntity
    {
        [Key]
        [StringLength(7)]
        public string SaleOrderId { get; set; }

        [StringLength(30)]
        public string ShipToName { get; set; }

        [StringLength(18)]
        public string ShipToPhone { get; set; }

        [StringLength(50)]
        public string ShipToAddress { get; set; }

        [StringLength(50)]
        public string ShipToStreet { get; set; }

        [StringLength(50)]
        public string ShipToDistrict { get; set; }

        [StringLength(50)]
        public string ShipToCity { get; set; }

        [StringLength(50)]
        public string ShipToCountry { get; set; }

        public virtual SaleOrder SaleOrder { get; set; }
    }
}
