using ComiShop.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ComiShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base()
        {

        }
        public string BankAccount { get; set; }
        public virtual PersonInfo PersonInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
