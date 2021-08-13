using RestWithAsp_core5.Model;
using RestWithAsp_core5.Repository;
using RestWithAsp_core5.Specification.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Especific
{
    public class BookSpecification : ISpecification<Book>
    {
        private readonly IGenericRepository<Book> _bookRepository;

        public BookSpecification(IGenericRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public bool IsSatisfiedBy(Book Entity)
        {
            return _bookRepository.FindById(Entity.Id) != null;
        }
    }
}
