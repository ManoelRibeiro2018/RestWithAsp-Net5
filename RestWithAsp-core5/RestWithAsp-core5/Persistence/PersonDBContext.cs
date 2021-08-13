using Microsoft.EntityFrameworkCore;
using RestWithAsp_core5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Persistence
{
    public class PersonDBContext : DbContext
    {
        public PersonDBContext(DbContextOptions<PersonDBContext> options) : base(options)
        {

        }

        public DbSet<Person>  Persons  { get; set; }
        public DbSet<Book>  Books { get; set; }
    }
}
