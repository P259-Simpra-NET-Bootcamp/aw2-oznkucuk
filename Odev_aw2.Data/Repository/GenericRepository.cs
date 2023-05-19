using Odev_aw2.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Odev_aw2.Data.Repository
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        protected readonly Aw2DbContext dbContext;

        public GenericRepository(Aw2DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Delete(Entity entity)
        {
            dbContext.Set<Entity>().Remove(entity);
        }

        public void DeleteById(int id)
        {
            var entity = dbContext.Set<Entity>().Find(id);
            dbContext.Set<Entity>().Remove(entity);
        }

        public List<Entity> GetAll()
        {
            return dbContext.Set<Entity>().ToList(); 

        }

        public Entity GetById(int id)
        {
            return dbContext.Set<Entity>().Find(id);
        }

        public List<Entity> GetCountry(Expression<Func<Entity, bool>> query)
        {
            return dbContext.Set<Entity>().Where(query).ToList();
        }

        public void Insert(Entity entity)
        {
            dbContext.Set<Entity>().Add(entity);
        }

        public void Update(Entity entity)
        {
            dbContext.Set<Entity>().Update(entity);

        }
    }
}
