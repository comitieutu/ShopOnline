namespace BookStore
{
    using BookStore.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ProductDetail")]
    public partial class ProductDetail : BaseEntity
    {
        [Key]
        [StringLength(7)]
        public string ProductId { get; set; }

        [StringLength(50)]
        public string DesDetail { get; set; }

        [StringLength(50)]
        public string ProductImage { get; set; }

        [StringLength(50)]
        public string Comment { get; set; }

        public virtual Product Product { get; set; }
    }
}
