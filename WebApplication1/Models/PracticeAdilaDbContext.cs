using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class PracticeAdilaDbContext : DbContext

    {
        public PracticeAdilaDbContext() : base()
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Data Source=.;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            // previous string:
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-9ACERJ5\\MSSQLSERVER01; Initial Catalog = PracticeAdilaDb; Integrated Security = True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Id = 1,
                    City = "Hasselt",
                    Country = "Belgium",
                    Name = "Luigi's"
                });
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Id = 2,
                    City = "Sint-Truiden",
                    Country = "Belgium",
                    Name = "Bombasta"
                });

        }
    }
}
