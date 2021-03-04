using Assign5_Books.Models.ViewMOdels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign5_Books.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<BookModel> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }


        public string Type { get; set; }
    }
}
