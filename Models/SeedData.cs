using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign5_Books.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookDBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    //Create book data for the website
                    new BookModel
                    {
                        ISBN = 978-0451419439,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        Category = "Fiction, Classic",
                        Price = 9.95,
                        PageNumber = 1488
                    },

                    new BookModel
                    {
                        ISBN = 978-0743270755,
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        Category = "Non-Fiction, Biography",
                        Price = 14.58,
                        PageNumber = 944
                    },

                    new BookModel
                    {
                        ISBN = 978-0553384611,
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        Category = "Non-Fiction, Biography",
                        Price = 21.54,
                        PageNumber =832
                    },

                    new BookModel
                    {
                        ISBN = 978-0812981254,
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        Category = "Non-Fiction, Biography",
                        Price = 11.61,
                        PageNumber = 864
                    },

                    new BookModel
                    {
                        ISBN = 978-0812974492,
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        Category = "Non-Fiction, Historical",
                        Price = 13.33,
                        PageNumber = 528
                    },

                    new BookModel
                    {
                        ISBN = 978-0804171281,
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        Category = "Fiction, Historical Fiction",
                        Price = 15.95,
                        PageNumber = 288
                    },

                     new BookModel
                     {
                         ISBN = 978-1455586691,
                         Title = "Deep Work",
                         Author = "Cal Newport",
                         Publisher = "Grand Central Publishing",
                         Category = "Non-Fiction, Self-Help",
                         Price = 14.99,
                         PageNumber = 304
                     },

                     new BookModel
                     {
                         ISBN = 978-1455523023,
                         Title = "It's Your Ship",
                         Author = "Michael Abrashoff",
                         Publisher = "Grand Central Publishing",
                         Category = "Non-Fiction, Self-Help",
                         Price = 21.66,
                         PageNumber = 240
                     },

                     new BookModel
                     {
                         ISBN = 978-1591847984,
                         Title = "The Virgin Way",
                         Author = "Richard Branson",
                         Publisher = "Portfolio",
                         Category = "Non-Fiction, Business",
                         Price = 29.16,
                         PageNumber = 400
                     },

                     new BookModel
                     {
                         ISBN = 978-0553393613,
                         Title = "Sycamore Row",
                         Author = "John Grisham",
                         Publisher = "Bantam",
                         Category = "Fiction, Thrillers",
                         Price = 15.03,
                         PageNumber = 642
                     },
                     new BookModel
                     {
                         ISBN = 978 - 0553234613,
                         Title = "Pride and Prejudice",
                         Author = "Jane Austen",
                         Publisher = "Barnes & Noble",
                         Category = "Romance, Satire",
                         Price = 10.99,
                         PageNumber = 358
                     },

                     new BookModel
                     {
                         ISBN = 978 - 0555673613,
                         Title = "The Peacegiver",
                         Author = "James L. Ferrell",
                         Publisher = "Deseret Book",
                         Category = "Religion",
                         Price = 17.99,
                         PageNumber = 204
                     },

                     new BookModel
                     {
                         ISBN = 978 - 0578493613,
                         Title = "Ahsoka",
                         Author = "E. K. Johnston",
                         Publisher = "Disney Press",
                         Category = "Science Fiction",
                         Price = 14.99,
                         PageNumber = 403
                     }


                );
                context.SaveChanges();
            }
        }
    }
}
