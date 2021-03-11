using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign5_Books.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem (BookModel book, int qty)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookID == book.BookID)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = qty,
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public void RemoveLine(BookModel book) =>
            Lines.RemoveAll(x => x.Book.BookID == book.BookID);

        public void Clear() => Lines.Clear();

        public decimal ComputeTotalSum() => Lines.Sum(e => 25 * e.Quantity); //price is hardcoded
        


        public class CartLine
        {
            public int CartLineID { get; set; }
            public BookModel Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
