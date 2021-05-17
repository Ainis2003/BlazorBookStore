using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data
{
    interface IBookService
    {
        List<Book> GetBooks();

        Book GetBook(int Id);
        void UpdateBook(Book book);
    }
}
