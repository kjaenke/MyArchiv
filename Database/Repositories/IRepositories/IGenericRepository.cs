namespace Database.Infrastructure
{
    using System;
    using System.Collections.Generic;

    public interface IGenericRepository<T> : IDisposable where T : class
    {
        T Get(ulong id);
        IEnumerable<T> Get();
        void Create(T entity);
        void Create(IEnumerable<T> entities);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
    }
}