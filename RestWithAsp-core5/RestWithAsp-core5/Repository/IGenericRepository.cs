using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Repository
{
    public interface IGenericRepository<T>
    {
        T Create(T Entity);
        T Update(T Entity, int id);
        void Delete(int id);
        List<T> FindAll();
        T FindById(int id);
    }
}
