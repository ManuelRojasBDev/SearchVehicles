using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchVehicles.Domain.Entities;

namespace SearchVehicles.Infrastructure.Data.Configuration
{
    public class VehicleByLocalityConfiguration : IEntityTypeConfiguration<VehicleByLocality>
    {
        public void Configure(EntityTypeBuilder<VehicleByLocality> builder)
        {
            builder
               .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .UseIdentityColumn();

            builder
               .HasOne(x => x.Vehicle)
               .WithMany(y => y.VehiclesByLocality)
               .HasForeignKey(x => x.IdVehicle);

            builder
                .HasOne(x => x.LocalityCollection)
                .WithMany(y => y.VehiclesByLocalityCollection)
                .HasForeignKey(x => x.IdCollectionLocality);

            builder
                .HasOne(x => x.LocalityReturn)
                .WithMany(y => y.VehiclesByLocalityReturn)
                .HasForeignKey(x => x.IdReturnLocality);

            builder
               .Property(x => x.Available)
               .IsRequired();

            builder.ToTable("VehiclesByLocality");
        }
    }
}
