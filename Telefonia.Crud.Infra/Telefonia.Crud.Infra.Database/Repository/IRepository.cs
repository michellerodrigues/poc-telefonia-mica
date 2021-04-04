using System;
using System.Collections.Generic;
using System.Text;

namespace Telefonia.Crud.Infra.Database.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Create(T entity);
        void Remove(T entity);
        int Count(Func<T, bool> predicate);

        IEnumerable<T> Find(Func<T, bool> predicate);

        T GetById(int id);

        void Update(T entity);
    }
}