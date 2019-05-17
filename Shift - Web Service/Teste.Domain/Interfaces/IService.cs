using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Teste.Domain.Entities;

namespace Teste.Domain.Interfaces
{
    public interface IService<T> where T : BaseEntity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Remove(int id);

        T Get(int id, params string[] includes);

        IList<T> Get(params string[] includes);

        IList<T> GetWhere(Expression<Func<T, bool>> predicate, params string[] includes);
    }
}
