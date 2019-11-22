using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.LibraryProject.Entity
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public List<Book> Books { get; set; }
        public int? Authorage { get; set; }

    }
}
