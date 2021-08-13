using RestWithAsp_core5.Model;
using RestWithAsp_core5.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Repository.Implementation
{
    public class BookRepository : IBookRepository
    {
        private readonly PersonDBContext _personDbContext;

        public BookRepository(PersonDBContext personDbContext)
        {
            _personDbContext = personDbContext;
        }
        public Book Create(Book Entity)
        {
            _personDbContext.Books.Add(Entity);
            _personDbContext.SaveChanges();
            return Entity;
        }

        public void Delete(int id)
        {
            var book = FindById(id);
            _personDbContext.Books.Remove(book);
            _personDbContext.SaveChanges();
        }

        public List<Book> FindAll()
        {
            return _personDbContext.Books.ToList();
        }

        public Book FindById(int id)
        {
            return _personDbContext.Books.SingleOrDefault(b => b.Id.Equals(id));
        }

        public Book Update(Book Entity, int id)
        {
            var book = FindById(id);
            _personDbContext.Entry(book).CurrentValues.SetValues(Entity);
            _personDbContext.SaveChanges();
            return Entity;
        }
    }
}
