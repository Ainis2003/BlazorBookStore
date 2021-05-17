using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data
{
    public class BookService : IBookService
    {
        private List<Book> books = new List<Book>
        {
            new Book
            {
                Id = 1,
                AuthorId = 1,
                Title = "Knyga 1",
                Description = "Knygos aprasymas",
                ReleaseDate = new DateTime(2000, 1, 1),
                Rating = 0,
            },
            new Book
            {
                Id = 2,
                AuthorId = 1,
                Title = "Knyga 2",
                Description = "Knygos aprasymas",
                ReleaseDate = new DateTime(2000, 1, 1),
                Rating = 0,
            },
            new Book
            {
                Id = 3,
                AuthorId = 2,
                Title = "Knyga 3",
                Description = "Knygos aprasymas",
                ReleaseDate = new DateTime(2000, 1, 1),
                Rating = 0,
            }
        };

        public Book GetBook(int Id)
        {
            return books.SingleOrDefault(x => x.Id == Id);
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        public void UpdateBook(Book book)
        {
            var getOldBook = GetBook(book.Id);
            getOldBook.Rating = book.Rating;
        }
    }
}
