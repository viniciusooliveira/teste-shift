using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces;
using Teste.Infra.Data.Repository;

namespace Teste.Service.Services
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        protected BaseRepository<T> repository = new BaseRepository<T>();

        public virtual T Post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Insert(obj);
            return obj;
        }

        public virtual T Put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Update(obj);
            return obj;
        }

        public virtual void Remove(int id)
        {
            if (id == 0)
                throw new ArgumentException("O id não pode ser zero.");

            repository.Remove(id);
        }

        public virtual IList<T> Get(params string[] includes) => includes != null && includes.Any() ? repository.SelectAll(includes) : repository.SelectAll();

        public virtual T Get(int id, params string[] includes)
        {
            if (id == 0)
                throw new ArgumentException("O id não pode ser zero.");

            return includes != null && includes.Any() ? repository.Select(id, includes) : repository.Select(id);
        }

        public virtual IList<T> GetWhere(Expression<Func<T, bool>> predicate, params string[] includes)
        {
            return includes != null && includes.Any() ? repository.SelectWhere(predicate, includes) : repository.SelectWhere(predicate);
        }

        protected void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }

    }
}
