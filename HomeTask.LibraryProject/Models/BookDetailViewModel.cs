﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.LibraryProject.Models
{
    public class BookDetailViewModel
    {
        public string BookName { get; set; }
        public string BookTitle { get; set; }
        public int ViewedCount { get; set; }
        public string ImageUrl { get; set; }
        public string AuthorName { get; set; }

    }
}
