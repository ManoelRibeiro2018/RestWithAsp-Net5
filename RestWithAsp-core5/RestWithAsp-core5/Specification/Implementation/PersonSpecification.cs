using RestWithAsp_core5.Model;
using RestWithAsp_core5.Repository;
using RestWithAsp_core5.Specification.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Specification.Implementation
{
    public class PersonSpecification : IPersonSpecification
    {
        private readonly IPersonRepository _genericRepository;

        public PersonSpecification(IPersonRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public bool IsSatisfiedBy(Person Entity)
        {
            return _genericRepository.FindById(Entity.Id) != null;
        }
    }
}
