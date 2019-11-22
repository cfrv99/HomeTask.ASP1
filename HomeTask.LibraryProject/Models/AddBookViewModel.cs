using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.LibraryProject.Models
{
    public class AddBookViewModel
    {
        public string BookName { get; set; }
        public string BookTitle { get; set; }
        public int BookYear { get; set; }
        public int AuthorId { get; set; }
        public string BookImageUrl { get; set; }
    }
}
