using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NLayer.Core;

namespace NLayer.Repository;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        // var p = new Product()
        // {
        //     ProductFeature = new ProductFeature()
        // };
        // Eğer bu şekilde bir nesne oluşturursak, ProductFeature'ın ProductId'si null olarak gelir.
        // ProductFeature nesnesi sadece Product nesnesi ile birlikte oluşturulabilir. 
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductFeature> ProductFeatures { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature
            {
                Id = 1,
                Color = "Red",
                Height = 100,
                Width = 200,
                ProductId = 1
            },
            new ProductFeature
            {
                Id = 2,
                Color = "Blue",
                Height = 100,
                Width = 200,
                ProductId = 2
            }
        );


        base.OnModelCreating(modelBuilder);
    }
}