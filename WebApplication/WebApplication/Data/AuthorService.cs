using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data
{
    public class AuthorService : IAuthorService
    {
        private List<Author> authors = new List<Author>
        {
            new Author
            {
                Id = 1,
                PenName = "Lorem",
                FirstName = "Ipsum",
                LastName = "Sit",
                EmailAddress = "Amet@gmail.com",
            },
            new Author
            {
                Id = 2,
                PenName = "Lorem",
                FirstName = "Ipsum",
                LastName = "Sit",
                EmailAddress = "Amet@gmail.com",
            },
        };
        public List<Author> GetAuthors()
        {
            return authors;
        }
    }
}
