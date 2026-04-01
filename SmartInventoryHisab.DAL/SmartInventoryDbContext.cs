using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartInventoryHisab.Model;

namespace SmartInventoryHisab.DAL;

public class SmartInventoryDbContext : IdentityDbContext<ApplicationUser>
{
    public SmartInventoryDbContext(DbContextOptions<SmartInventoryDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Sale> Sales { get; set; } = null!;
    public DbSet<Purchase> Purchases { get; set; } = null!;
    public DbSet<StockTransaction> StockTransactions { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)");

        // Seeding 30 Products
        var products = new List<Product>();
        string[] categories = { "Electronics", "Furniture", "Appliance", "Kitchen", "Stationery" };
        Random rand = new Random(42);

        for (int i = 1; i <= 30; i++)
        {
            var category = categories[rand.Next(categories.Length)];
            products.Add(new Product
            {
                Id = i,
                Name = $"{category} Item {i}",
                Description = $"High quality {category.ToLower()} product for daily use.",
                Price = (decimal)(rand.NextDouble() * 500 + 10),
                CurrentStock = rand.Next(0, 50),
                ImageUrl = "/images/products/placeholder.png",
                CreatedAt = DateTime.UtcNow.AddMonths(-rand.Next(0, 12)).AddDays(-rand.Next(0, 30))
            });
        }

        builder.Entity<Product>().HasData(products);
    }
}

