using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookClubApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookClubApp.Persistence
{
    public class DataContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        
    }
}