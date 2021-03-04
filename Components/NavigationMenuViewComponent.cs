using Assign5_Books.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign5_Books.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {

        private IBookRepository repository;

        public NavigationMenuViewComponent (IBookRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["category"];
            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));      
        }
    }
}
