using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookClubApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public ICollection<Book> BooksWritten { get; set; } = new List<Book>();

    }
}