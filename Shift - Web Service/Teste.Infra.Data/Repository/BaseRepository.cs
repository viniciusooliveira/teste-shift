using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces;
using Teste.Infra.Data.Context;

namespace Teste.Infra.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private TesteContext context = new TesteContext();
        
        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            context.Set<T>().Remove(Select(id));
            context.SaveChanges();
        }

        public IList<T> SelectAll()
        {
            return context.Set<T>().ToList();
        }

        public IList<T> SelectAll(params string[] includes)
        {
            var query = context.Set<T>().AsQueryable();
            foreach (string include in includes)
            {
                query = query.Include(include);
            }
            return query.ToList();
        }

        public IList<T> SelectWhere(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate).ToList();
        }

        public IList<T> SelectWhere(Expression<Func<T, bool>> predicate, params string[] includes)
        {
            var query = context.Set<T>().AsQueryable();
            foreach (string include in includes)
            {
                query = query.Include(include);
            }
            return query.Where(predicate).ToList();
        }

        public T Select(int id)
        { 
            return context.Set<T>().Find(id);
        }

        public T Select(int id, params string[] includes)
        {
            var query = context.Set<T>().AsQueryable();
            foreach (string include in includes)
            {
                query = query.Include(include);
            }
            return query.FirstOrDefault(o => o.Id == id);
        }

    }
}
