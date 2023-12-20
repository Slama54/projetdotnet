using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Employee { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                 new Book { Id = 1, Name = "Book 1", Age = 18, IsActive = 1 },
                new Book { Id = 2, Name = "Book 2", Age = 28, IsActive = 1 },
                new Book { Id = 3, Name = "Book 3", Age = 35, IsActive = 0 }
                );
        }
    }
}
