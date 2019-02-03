using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Entity;

namespace PMS.Data.Repositories.HMS
{
    public class GenericRepository<T> : Interfaces.HMS.IGenericRepository<T> where T : class
    {
        private PMSEntities dataContext;
        private IDbSet<T> dbEntity;

        public GenericRepository()
        {
            dataContext = new PMSEntities();
            dbEntity = dataContext.Set<T>();
        }
        public void Add(T model)
        {
            dbEntity.Add(model);
            dataContext.SaveChanges();
        }

        public void Delete(T model)
        {
            dataContext.Entry(model).State = EntityState.Modified;
            dataContext.SaveChanges();
        }

        public void Edit(T model)
        {
            dataContext.Entry(model).State = EntityState.Modified;
            dataContext.SaveChanges();
        }

        public T Get(int id)
        {
            return dbEntity.Find(id);
        }

        public List<T> GetAll()
        {
            return dbEntity.ToList();
        }

        public int GetCount()
        {
            return dbEntity.Count();
        }
    }
}
