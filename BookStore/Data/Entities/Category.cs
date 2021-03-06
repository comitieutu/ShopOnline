namespace BookStore
{
    using BookStore.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Category")]
    public partial class Category : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [StringLength(7)]
        public string CategoryId { get; set; }

        [StringLength(20)]
        public string CategoryName { get; set; }

        [StringLength(50)]
        public string CategoryDes { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
