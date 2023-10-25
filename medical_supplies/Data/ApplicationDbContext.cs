using medical_supplies.Models;
using Microsoft.EntityFrameworkCore;

namespace medical_supplies.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "New born", Description = "new baby less than 2 month", DisplyOrder = 1 },
                new Category { Id = 2, Name = "children", Description = "babies between 2m-13y", DisplyOrder = 2 },
                new Category { Id = 3, Name = "Band aid", Description = "", DisplyOrder = 3 }
                );
        }
    }
}
