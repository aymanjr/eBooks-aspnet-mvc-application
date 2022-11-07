using eBooks.Models;
using Microsoft.EntityFrameworkCore;

namespace eBooks.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author_Book>().HasKey(am => new
            {
                am.AuthorId,
                am.BookId
            });
            modelBuilder.Entity<Author_Book>().HasOne(m => m.Book).WithMany(am => am.Author_Books).HasForeignKey(m => m.BookId);
            modelBuilder.Entity<Author_Book>().HasOne(m => m.Author).WithMany(am => am.Author_Books).HasForeignKey(m => m.AuthorId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Author_Book> Author_Books { get; set; }
        public DbSet<BookStore> BookStores { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

    }
}
