using System;
using System.Collections.Generic;

namespace Lesson20___GenericsExample
{
    class EntityRepository<T> : IEntityRepository<T> where T : class, IEntity, new()
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}