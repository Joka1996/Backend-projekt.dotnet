using Microsoft.EntityFrameworkCore;
//importera models
using Backend_projekt.Models;

namespace Backend_projekt.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        

        //skapa tabellerna till databasen
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }

}
