namespace ComiShop
{
    using ComiShop.Entities;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Shipper")]
    public partial class Shipper : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shipper()
        {
            SaleOrders = new HashSet<SaleOrder>();
        }

        [StringLength(20)]
        public string Company { get; set; }

        [StringLength(20)]
        public string ContactName { get; set; }

        [StringLength(18)]
        public string ContactPhone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
    }
}
