using System.Collections.Generic;

namespace WebApiStudios.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
       IEnumerable<TEntity> All { get; }
       void Add(TEntity entity);
       void Delete(TEntity entity);
       void Update(TEntity entity);
       TEntity FindByName(string name);
    }
}