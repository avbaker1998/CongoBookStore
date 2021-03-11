using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assign5_Books.Infrastructure;
using Assign5_Books.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assign5_Books.Pages
{
    public class PayModel : PageModel
    {
        private IBookRepository repository;

        //Contrustor
        public PayModel (IBookRepository repo)
        {
            repository = repo;
        }

        //Properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        //Methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = ReturnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            BookModel book = repository.Books.FirstOrDefault(b => b.BookID == bookId);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(book, 1);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Book.BookID == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
