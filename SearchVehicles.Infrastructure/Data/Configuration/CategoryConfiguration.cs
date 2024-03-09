using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchVehicles.Domain.Entities;

namespace SearchVehicles.Infrastructure.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(x => x.IdCategory);

            builder
                .Property(x => x.IdCategory)
                .UseIdentityColumn();

            builder
                .Property(x => x.CategoryName)
                .IsRequired()
                .HasMaxLength(200);

            builder
               .Property(x => x.Available)
               .IsRequired();

            builder.ToTable("Categories");
        }
    }
}
