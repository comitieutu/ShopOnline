using ComiShop.Data;
using ComiShop.Entities;
using ComiShop.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace ComiShop.Implementations
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly ApplicationDbContext _context;
        protected DbSet<T> EntitySet => _context.Set<T>();
        public virtual IQueryable<T> Entities => EntitySet.AsQueryable();

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public T Get(params object[] keyValues)
        {
            var entity = EntitySet.Find(keyValues);
            return entity; //?? throw new EntityNotFoundException(keyValues);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return Entities.Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return Entities;
        }

        public void Create(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Delete(params object[] keyValues)
        {
            var entity = Get(keyValues);
            entity.Deleted = true;
            Edit(entity);
        }

        public int Delete(Expression<Func<T, bool>> predicate)
        {
            var entities = Get(predicate);
            entities.ToList().ForEach(DeleteEntity);
            return entities.Count();
        }

        public void Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        private void DeleteEntity(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }
        public T GetByUId(Guid keyValue)
        {
            return EntitySet.Where(e => e.UniqueId == keyValue).FirstOrDefault();
        }
        public EntityEntry GetTracking(T entity)
        {
            return _context.Entry(entity);
        }
    }
}
