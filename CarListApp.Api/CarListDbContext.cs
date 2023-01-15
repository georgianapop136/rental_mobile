using Microsoft.EntityFrameworkCore;

namespace CarListApp.Api
{
    public class CarListDbContext : DbContext
    {
        public CarListDbContext(DbContextOptions<CarListDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    Brand = "Honda",
                    Model = "Fit",
                    Year = "ABC"
                },
                new Car
                {
                    Id = 2,
                    Brand = "Honda",
                    Model = "Civic",
                    Year = "ABC2"
                },
                new Car
                {
                    Id = 3,
                    Brand = "Honda",
                    Model = "Stream",
                    Year = "ABC1"
                },
                new Car
                {
                    Id = 4,
                    Brand = "Nissan",
                    Model = "Note",
                    Year = "ABC4"
                },
                new Car
                {
                    Id = 5,
                    Brand = "Nissan",
                    Model = "Atlas",
                    Year = "ABC5"
                },
                new Car
                {
                    Id = 6,
                    Brand = "Nissan",
                    Model = "Dualis",
                    Year = "ABC6"
                },
                new Car
                {
                    Id = 7,
                    Brand = "Nissan",
                    Model = "Murano",
                    Year = "ABC7"
                },
                new Car
                {
                    Id = 8,
                    Brand = "Audi",
                    Model = "A5",
                    Year = "ABC8"
                },
                new Car
                {
                    Id = 9,
                    Brand = "BMW",
                    Model = "M3",
                    Year = "ABC9"
                },
                new Car
                {
                    Id = 10,
                    Brand = "Jaguar",
                    Model = "F-Pace",
                    Year = "ABC10"
                }
            );
        }
    }
}