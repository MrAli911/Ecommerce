using Ecommerce.Data;
using Ecommerce.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected EcommerceDbContext context;

        public BaseRepository(EcommerceDbContext context)
        {
            this.context = context;
        }

        public void Delete(TEntity entity)
        {
            context.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity GetEntityById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            context.Add(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(TEntity id)
        {
            context.Set<TEntity>().Update(id);
        }
    }
}
      
   
