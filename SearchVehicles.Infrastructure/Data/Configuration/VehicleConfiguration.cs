using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchVehicles.Domain.Entities;

namespace SearchVehicles.Infrastructure.Data.Configuration
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder
              .HasKey(x => x.IdVehicle);

            builder
                .Property(x => x.IdVehicle)
                .UseIdentityColumn();

            builder
              .HasOne(x => x.Category)
              .WithMany(y => y.Vehicles)
              .HasForeignKey(x => x.IdCategory);

            builder
                .Property(x => x.VehicleDescription)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .Property(x => x.Plate)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .Property(x => x.Model)
                .IsRequired()
                .HasMaxLength(200);

            builder
               .Property(x => x.Available)
               .IsRequired();

            builder.ToTable("Vehicles");
        }
    }
}
