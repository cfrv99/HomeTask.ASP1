using HomeTask.LibraryProject.Entity;
using HomeTask.LibraryProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.LibraryProject.Controllers
{
    public class BookController : Controller
    {
        private readonly DataContext context;

        public BookController(DataContext context)
        {
            this.context = context;
        }


        public IActionResult Index()
        {
            var data = context.Books
                .Include(i => i.Author)
                .Select(i => new AllBookViewModel
                {
                    BookId = i.Id,
                    BookName = i.Name,
                    BookTitle = i.Title,
                    AuthorName = i.Author.AuthorName,
                    ImageUrl = i.ImageUrl,
                    ViewedCount = i.ViewCount
                })
                .OrderByDescending(i => i.ViewedCount)
                .ToList();
            return View(data);
        }

        public IActionResult Detail(int id)
        {
            var book = context.Books.FirstOrDefault(i => i.Id == id);

            book.ViewCount = book.ViewCount + 1;
            context.SaveChanges();

            BookDetailViewModel data = new BookDetailViewModel()
            {
                BookName = book.Name,
                BookTitle = book.Title,
                ImageUrl = book.ImageUrl,
                ViewedCount = book.ViewCount,
                //AuthorName=book.Author.AuthorName
            };


            var entity = context.Books
                .Include(i => i.Author)
                .Where(i => i.Id == id)
                .Select(i => new BookDetailViewModel
                {
                    BookName = i.Name,
                    BookTitle = i.Title,
                    ImageUrl = i.ImageUrl,
                    ViewedCount = i.ViewCount,
                    AuthorName = i.Author.AuthorName
                }).FirstOrDefault();

            return View(entity);
        }

        public IActionResult AddBook()
        {

            ViewBag.Authors = new SelectList(context.Authors, "Id", "AuthorName");
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(AddBookViewModel model, IFormFile file)
        {
            if (ModelState.IsValid)
            {

                if (file != null)
                {

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", file.FileName);

                    using (var fs = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(fs);
                        model.BookImageUrl = file.FileName;
                    }

                }


                Book b = new Book()
                {
                    Name = model.BookName,
                    AuthorId = model.AuthorId,
                    Title = model.BookTitle,
                    ImageUrl = model.BookImageUrl

                };

                context.Books.Add(b);
                context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            ViewBag.Authors = new SelectList(context.Authors, "Id", "AuthorName");

            return View(model);
        }

    }
}
