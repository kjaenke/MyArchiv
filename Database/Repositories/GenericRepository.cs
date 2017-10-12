namespace Database.Repositories
{
    using System.Collections.Generic;
    using Infrastructure;
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected GenericRepository(DatabaseContext context) => Context = context;
        private DatabaseContext Context { get; }

        public void Dispose() => Context?.Dispose();

        public T Get(ulong id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            throw new System.NotImplementedException();
        }

        public void Create(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Create(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }
    }
}