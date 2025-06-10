using Bookstore_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore_Razor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category { CID = 1, Name = "Action", DisplayOrder = 1 },
                    new Category { CID = 2, Name = "Sci-Fi", DisplayOrder = 2 },
                    new Category { CID = 3, Name = "History", DisplayOrder = 3 }
                );
        }
    }
}
