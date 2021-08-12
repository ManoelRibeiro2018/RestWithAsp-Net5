using RestWithAsp_core5.Model;
using System.Collections.Generic;

namespace RestWithAsp_core5.Services
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person Update(Person person, int id);
        void Delete (int id);
        List<Person> FindAll();
        Person FindById(int id);
        

       
    }
}
