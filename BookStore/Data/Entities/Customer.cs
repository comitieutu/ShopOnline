namespace BookStore
{
    using BookStore.Data;
    using BookStore.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Customer")]
    public partial class Customer : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            SaleOrders = new HashSet<SaleOrder>();
        }

        [StringLength(7)]
        public string CustomerId { get; set; }

        [StringLength(10)]
        public CustType CustomerType { get; set; }

        [StringLength(20)]
        public string BankAccount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastUpdate { get; set; }
        //public StoreUser User { get; set; }

        public virtual PersonInfo PersonInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
    }
}
