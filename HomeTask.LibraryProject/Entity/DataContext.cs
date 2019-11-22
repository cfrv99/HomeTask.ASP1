using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.LibraryProject.Entity
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
