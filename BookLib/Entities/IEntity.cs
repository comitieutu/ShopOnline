using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Entities
{
    public interface IEntity
    {
        byte[] Timestamp { get; set; }
    }

    public abstract class Entity : IEntity
    {
        public byte[] Timestamp { get; set; }
    }

    public abstract class Entity<T> : Entity
    {
        public T Id { get; set; }
        bool Deleted { get; set; }
    }

    public abstract class BaseEntity : Entity<int> { }
}
