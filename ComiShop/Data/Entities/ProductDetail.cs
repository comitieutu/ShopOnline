namespace ComiShop
{
    using ComiShop.Entities;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ProductDetail")]
    public partial class ProductDetail : BaseEntity
    {
        public int ProductId { get; set; }

        [StringLength(50)]
        public string ProductImage { get; set; }

        public virtual Product Product { get; set; }
    }
}
