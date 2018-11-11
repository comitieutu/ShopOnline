using ComiShop.Data;
using ComiShop.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComiShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base()
        {

        }
        [StringLength(10)]
        public CustType CustomerType { get; set; }

        [StringLength(20)]
        public string BankAccount { get; set; }
        public virtual PersonInfo PersonInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
