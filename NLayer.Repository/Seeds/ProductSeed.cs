using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds;

public class ProductSeed : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Pilot Pen", // Turkish version: "Pilot Kalem"
                Price = 100,
                Stock = 20,
                CreateDate = DateTime.Now
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Pencil", // Turkish version: "Kalem"
                Price = 200,
                Stock = 50,
                CreateDate = DateTime.Now
            },
            new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "TBallpoint Pen", // Turkish version: "Tükenmez Kalem"
                Price = 300,
                Stock = 100,
                CreateDate = DateTime.Now
            },
            new Product
            {
                Id = 4,
                CategoryId = 2,
                Name = "Crime and Punishment", // Turkish version: "Suç ve Ceza"
                Price = 100,
                Stock = 20,
                CreateDate = DateTime.Now
            },
            new Product
            {
                Id = 5,
                CategoryId = 2,
                Name = "The Great Speech", // Turkish version: "Nutuk"
                Price = 200,
                Stock = 50,
                CreateDate = DateTime.Now
            }
        );
    }
}