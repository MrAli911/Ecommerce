using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class 
    {
       IEnumerable<TEntity> GetAll();
        TEntity GetEntityById(int id);
        void Insert(TEntity entity);
        void Update(TEntity id);
        void Delete(TEntity entity);
        void Save();
    }
   
}
