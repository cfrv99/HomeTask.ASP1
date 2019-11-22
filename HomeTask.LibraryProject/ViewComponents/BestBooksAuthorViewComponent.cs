using HomeTask.LibraryProject.Entity;
using HomeTask.LibraryProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.LibraryProject.ViewComponents
{
    public class BestBooksAuthorViewComponent : ViewComponent
    {
        private readonly DataContext context;

        public BestBooksAuthorViewComponent(DataContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var entity = context.Books
                .Include(i => i.Author)
                .ThenInclude(i=>i.Books)
                .Select(i => new AuthorBookCountViewModel()
                {
                    AuthorName = i.Author.AuthorName,
                    BookCount = i.Author.Books.Count(),
                    Books = i.Author.Books.ToList()
                })
                .OrderByDescending(i => i.BookCount)
                .FirstOrDefault();

            return View(entity);
        }

    }
}
