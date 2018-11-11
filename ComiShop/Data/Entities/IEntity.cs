using ComiShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ComiShop.Entities
{
    public interface IEntity
    {
        bool? Deleted { get; set; }
        Guid UniqueId { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }

    public abstract class Entity : IEntity
    {
        public Guid UniqueId { get; set; } = Guid.NewGuid();
        public bool? Deleted { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }

    public abstract class BaseEntity : Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), ScaffoldColumn(false)]
        [Key]
        public int Id { get; set; }
    }
}
