using RestWithAsp_core5.Model;
using RestWithAsp_core5.Persistence;
using RestWithAsp_core5.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Services.Implementation
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository  personRepository)
        {
            _personRepository = personRepository;
        }
        public Person Create(Person person)
        {
            var personReturn =  _personRepository.Create(person);
            return personReturn;
        }
        public Person Update(Person person, int id)
        {
            var personExists = _personRepository.Update(person, id);

            return personExists;
        }

        public void Delete(int id)
        {
            _personRepository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _personRepository.FindAll();
        }

        public Person FindById(int id)
        {
            return _personRepository.FindById(id);
        }

      
    }
}
