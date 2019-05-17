using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Teste.Domain.Entities;

namespace Teste.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Remove(int id);

        T Select(int id);

        IList<T> SelectAll();

        IList<T> SelectWhere(Expression<Func<T, bool>> predicate);
    }
}
