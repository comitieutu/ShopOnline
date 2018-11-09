namespace BookStore
{
    using BookStore.Entities;
    using System;
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

        [StringLength(7)]
        public string ProductId { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string ProductDes { get; set; }

        [StringLength(7)]
        public string CategoryId { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastUpdate { get; set; }

        public virtual Category Category { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }
    }
}
