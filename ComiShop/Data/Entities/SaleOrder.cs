namespace ComiShop
{
    using ComiShop.Entities;
    using ComiShop.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SaleOrder")]
    public partial class SaleOrder : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaleOrder()
        {
            SaleOrderDetails = new HashSet<SaleOrderDetail>();
        }
        
        public string UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OrderDate { get; set; }

        [StringLength(20)]
        public string OrderStatus { get; set; }

        public double? TotalPrice { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ShippedDate { get; set; }
        
        public int ShipperId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ReceiveProduct ReceiveProduct { get; set; }

        public virtual Shipper Shipper { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }
    }
}
