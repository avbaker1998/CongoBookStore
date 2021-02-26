using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign5_Books.Models
{
    public interface IBookRepository
    {
        IQueryable<BookModel> Books { get; }
    }
}
