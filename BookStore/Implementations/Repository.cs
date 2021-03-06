﻿using BookStore.Data;
using BookStore.Entities;
using BookStore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BookStore.Implementations
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly AppDbContext _context;
        protected DbSet<T> EntitySet => _context.Set<T>();
        public virtual IQueryable<T> Entities => EntitySet.AsQueryable();

        public Repository(AppDbContext context)
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

        //public IQueryable<T> GetByCategory(string id)
        //{
        //    var product = EntitySet.Find(id).
        //    category.
        //    return Entities;
        //}

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
            DeleteEntity(entity);
        }

        public int Delete(Expression<Func<T, bool>> predicate)
        {
            var entities = Get(predicate);
            entities.ToList().ForEach(DeleteEntity);
            return entities.Count();
        }

        public void Edit(T entity)
        {
            //_context.Entry(entity).State = EntityState.Modified;
        }

        private void DeleteEntity(T entity)
        {
            //if (entity is ILogicalDeleteEntity unDeletableEntity)
            //{
            //    unDeletableEntity.Deleted = true;
            //    _context.Entry(unDeletableEntity).State = EntityState.Modified;
            //}
            //else
            //{
            //    _context.Entry(entity).State = EntityState.Deleted;
            //}
        }
    }
}
