using System.Collections.Generic;

namespace Lesson20___GenericsExample
{
    interface IEntityRepository<T> where T : class, IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T Get(int id);
    }
}