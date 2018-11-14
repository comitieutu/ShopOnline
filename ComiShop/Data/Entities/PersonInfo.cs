namespace ComiShop
{
    using ComiShop.Entities;
    using ComiShop.Models;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PersonInfo")]
    public partial class PersonInfo : BaseEntity
    {
        public string UserId { get; set; }
        [StringLength(15)]
        public string FirstName { get; set; }

        [StringLength(15)]
        public string LastName { get; set; }

        [StringLength(5)]
        public string Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Country { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
