using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assign5_Books.Models
{
    public class BookModel
    {
        //Book Id, wont be printed
        [Key]
        public int BookID { get; set; }
        //ISBN number for the book
        [RegularExpression("^[0-9]+(-[0-9]+)+$")]
        public int ISBN { get; set; }
        //Title of the book
        [Required]
        public string Title { get; set; }
        //Author of the book
        [Required]
        public string Author { get; set; }
        //Publisher of the book
        [Required]
        public string Publisher { get; set; }
        //Catergory the book is listed under
        [Required]
        public string Category { get; set; }
        //Price of the book
        [Required]
        public double Price { get; set; }
        [Required]
        public int PageNumber { get; set; }
        public string Type { get;  set; }
    }
}
