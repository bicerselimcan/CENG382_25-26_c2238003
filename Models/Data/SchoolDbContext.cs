using Microsoft.EntityFrameworkCore;
using DotNetWeek5App.Models;

namespace DotNetWeek5App.Models.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

        public DbSet<Class> Classes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Password = "1234",
                    Role = "admin",
                    IsActive = true,
                    CreatedAt = new DateTime(2025, 5, 1)
                },
                new User
                {
                    Id = 2,
                    Username = "selimcan",
                    Password = "selimcan",
                    Role = "moderator",
                    IsActive = true,
                    CreatedAt = new DateTime(2025, 5, 1)
                }
            );

            // 6. haftada yaptığımız 100 class'ı oluşturmak için
            var classes = new List<Class>();
            for (int i = 1; i <= 100; i++)
            {
                classes.Add(new Class
                {
                    Id = i,
                    Name = $"Class {i}",
                    PersonCount = 10 + (i % 30),
                    Description = $"This is class {i}",
                    IsActive = true,
                    CreatedAt = new DateTime(2025, 5, 1)
                });
            }

            modelBuilder.Entity<Class>().HasData(classes);
        }
    }
}