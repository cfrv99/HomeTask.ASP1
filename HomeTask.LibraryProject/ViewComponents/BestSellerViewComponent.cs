using HomeTask.LibraryProject.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.LibraryProject.ViewComponents
{
    public class BestSellerViewComponent:ViewComponent
    {
        private readonly DataContext context;

        public BestSellerViewComponent(DataContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var data = context.Books
                .OrderByDescending(i => i.ViewCount)
                .FirstOrDefault();
            return View("Default",data);
        }
    }
}
