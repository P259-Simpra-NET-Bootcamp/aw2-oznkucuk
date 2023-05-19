using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Odev_aw2.Data.Repository
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        Entity GetById(int id);
        void Insert(Entity entity);
        void Update(Entity entity);
        void DeleteById(int id);
        void Delete(Entity entity);
        List<Entity> GetAll();
        public List<Entity> GetCountry(Expression<Func<Entity, bool>> query);
    }

}
