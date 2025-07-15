using Microsoft.EntityFrameworkCore;

namespace Select2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Books" },
                new Category { Id = 3, Name = "Clothing" },
                new Category { Id = 4, Name = "Home & Kitchen" },
                new Category { Id = 5, Name = "Toys" },
                new Category { Id = 6, Name = "Health & Beauty" },
                new Category { Id = 7, Name = "Sports" },
                new Category { Id = 8, Name = "Automotive" },
                new Category { Id = 9, Name = "Garden" },
                new Category { Id = 10, Name = "Office Supplies" }
            );

            // Seed Products (100)
            var products = new List<Product>();
            var rand = new Random();
            for (int i = 1; i <= 100; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    Description = $"Description for product {i}",
                    Price = Math.Round((decimal)(rand.NextDouble() * 500 + 1), 2), // Between 1.00 and 500.00
                    CategoryId = rand.Next(1, 11) // Category 1 to 10
                });
            }

            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}
