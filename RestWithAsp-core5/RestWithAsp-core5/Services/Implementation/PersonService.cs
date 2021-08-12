﻿using RestWithAsp_core5.Model;
using RestWithAsp_core5.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Services.Implementation
{
    public class PersonService : IPersonService
    {
        private readonly PersonDBContext _personDBContext;

        public PersonService(PersonDBContext personDBContext)
        {
            _personDBContext = personDBContext;
        }
        public Person Create(Person person)
        {
            _personDBContext.Person.Add(person);
            _personDBContext.SaveChanges();
            var personReturn = FindById(person.Id);

            return personReturn;
        }
        public Person Update(Person person, int id)
        {
            var personExists = FindById(id);
            if (personExists == null)
            {
                return null;
            }

            _personDBContext.Entry(personExists).CurrentValues.SetValues(person);

            _personDBContext.SaveChanges();

            return person;
        }

        public void Delete(int id)
        {

            var personExists = FindById(id);
            _personDBContext.Person.Remove(personExists);
            _personDBContext.SaveChanges();
        }

        public List<Person> FindAll()
        {
            return _personDBContext.Person.ToList();
        }

        public Person FindById(int id)
        {
            return _personDBContext.Person.Where(p => p.Id == id).SingleOrDefault();
        }

      
    }
}