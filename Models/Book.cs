using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookClubApp.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Summary { get; set; }

        public string ISBN { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();
    }
}