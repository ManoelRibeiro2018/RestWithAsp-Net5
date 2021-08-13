using RestWithAsp_core5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Repository.Implementation
{
    public class BookRepository : IGenericRepository<Book>
    {
        public Book Create(Book Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> FindAll()
        {
            throw new NotImplementedException();
        }

        public Book FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Book Update(Book Entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
