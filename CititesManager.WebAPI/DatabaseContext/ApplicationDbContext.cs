using CititesManager.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CititesManager.WebAPI.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public ApplicationDbContext()
        {

        }

        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(new City() { CityId = Guid.NewGuid(), CityName = "Toronto" });
            modelBuilder.Entity<City>().HasData(new City() { CityId = Guid.NewGuid(), CityName = "Dallas" });
        }
    }
}
