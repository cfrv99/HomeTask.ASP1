using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.LibraryProject.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int BookTime { get; set; }
        public string ImageUrl { get; set; }
        public int ViewCount { get; set; } = 0;
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
