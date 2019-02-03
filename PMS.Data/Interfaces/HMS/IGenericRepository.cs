using System.Collections.Generic;

namespace PMS.Data.Interfaces.HMS
{
    public interface IGenericRepository<T> where T:class
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T model);
        void Edit(T model);
        void Delete(T model);
        int GetCount();
    }
}
