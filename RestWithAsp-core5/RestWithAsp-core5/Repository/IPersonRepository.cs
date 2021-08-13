using RestWithAsp_core5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person Update(Person person, int id);
        void Delete(int id);
        List<Person> FindAll();
        Person FindById(int id);
    }
}
