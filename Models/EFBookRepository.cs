using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign5_Books.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookDBContext _context;

        //Constructor
        public EFBookRepository (BookDBContext context)
        {
            _context = context;
        }
        public IQueryable<BookModel> Books => _context.Books;
    }
}
