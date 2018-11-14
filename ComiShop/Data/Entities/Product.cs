namespace ComiShop
{
    using ComiShop.Data.Entities;
    using ComiShop.Entities;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Product")]
    public partial class Product : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            SaleOrderDetails = new HashSet<SaleOrderDetail>();
        }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string ProductDes { get; set; }
        [StringLength(50)]
        public string DesDetail { get; set; }
        public int CategoryId { get; set; }

        public int? Quantity { get; set; }

        public double? UnitPrice { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<ProductDetail> ProductDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
