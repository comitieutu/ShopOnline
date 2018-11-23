namespace ComiShop
{
    using ComiShop.Entities;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Shipper")]
    public partial class Shipper : BaseEntity
    {
        public string Company { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
    }
}
