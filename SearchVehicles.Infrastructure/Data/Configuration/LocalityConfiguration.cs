using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchVehicles.Domain.Entities;

namespace SearchVehicles.Infrastructure.Data.Configuration
{
    public class LocalityConfiguration : IEntityTypeConfiguration<Locality>
    {
        public void Configure(EntityTypeBuilder<Locality> builder)
        {
            builder
                .HasKey(x => x.IdLocality);

            builder
                .Property(x => x.IdLocality)
                .UseIdentityColumn();

            builder
                .Property(x => x.LocalityName)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .Property(x => x.LocalityAddress)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .Property(x => x.FreeCapacity)
                .IsRequired();

            builder
                .Property(x => x.TotalCapacity)
                .IsRequired();

            builder
               .Property(x => x.Available)
               .IsRequired();

            builder.ToTable("Localities");
        }
    }
}
