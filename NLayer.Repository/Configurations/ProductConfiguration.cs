using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Stock).IsRequired(); // 
        builder.Property(x => x.Price).IsRequired()
            .HasColumnType("decimal(18,2)"); // Toplam 18 basamaklı, virgülden sonra 2 basamaklı bir sayı olacak. yani 1234567890123456,78 gibi bir sayı olabilir.

        builder.ToTable("Products");

        builder.HasOne(x => x.Category).WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryId); // Product'ın bir Category'si olacak ve
        // bir Category'nin birden fazla Product'ı olacak.
    }
}