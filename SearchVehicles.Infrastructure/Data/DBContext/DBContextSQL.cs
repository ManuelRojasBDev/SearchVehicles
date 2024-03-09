using Microsoft.EntityFrameworkCore;
using SearchVehicles.Domain.Entities;
using SearchVehicles.Infrastructure.Data.Configuration;

namespace SearchVehicles.Infrastructure.Data.DBContext
{
    public class DBContextSQL : DbContext, IDBContextSQL
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Locality> Locality { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<VehicleByLocality> VehiclesByLocality { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;Initial Catalog = MilesCarRentalDB;Integrated Security = True;Trust Server Certificate = true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new LocalityConfiguration());
            builder.ApplyConfiguration(new VehicleByLocalityConfiguration());
            builder.ApplyConfiguration(new VehicleConfiguration());
        }
    }
}
