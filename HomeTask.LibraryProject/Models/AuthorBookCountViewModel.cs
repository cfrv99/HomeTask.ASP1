using HomeTask.LibraryProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.LibraryProject.Models
{
    public class AuthorBookCountViewModel
    {
        public string AuthorName { get; set; }
        public int BookCount { get; set; }
        public List<Book> Books { get; set; }
    }
}
